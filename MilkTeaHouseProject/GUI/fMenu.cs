﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaShopManagement.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DAL;

namespace MilkTeaHouseProject
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        #region Method
        public void LoadMenu()
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();
            bool setcolor = true;

            foreach (Drink drink in drinks)
            {
                if (setcolor == true)
                    setcolor = false;
                else
                    setcolor = true;

                MenuItem item = new MenuItem(drink.ID, drink.Name, drink.Price, drink.Category, drink.Image, setcolor, drink.OriginPrice, drink.Count);

                item.onDel += DrinkItem_onDel;
                item.onEdit += DrinkItem_onEdit;

                item.Tag = drink;
                flowLayoutPanelMenu.Controls.Add(item);
            }
        }

        private void LoadSize()
        {
            foreach (Control item in flowLayoutPanelMenu.Controls)
            {
                item.Width = flowLayoutPanelMenu.Width;
            }

            int space = flowLayoutPanelMenu.Width / 6;
            lbID.Location = new Point((int)(space * 0.8), 10);
            lbCategory.Location = new Point((int)(space * 2), 10);
            lbName.Location = new Point(space * 3, 10);
            lbOriginPrice.Location = new Point(space * 4, 10);
            lbPrice.Location = new Point((int)(space * 4.8), 10);
            lbCount.Location = new Point((int)(space * 5.5), 10);
        }

        public void SearchDrink(string search)
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();
            this.flowLayoutPanelMenu.Controls.Clear();
            bool setcolor = true;

            foreach (Drink drink in drinks)
            {
                string name = drink.Name;
                if (name.ToLower().Contains(this.txtSearch.Text.ToLower()))
                {
                    if (setcolor == true)
                        setcolor = false;
                    else
                        setcolor = true;

                    MenuItem DrinkItem = new MenuItem(drink.ID, drink.Name, drink.Price, drink.Category, drink.Image, setcolor, drink.OriginPrice, drink.Count);
                    DrinkItem.Tag = drink;
                    DrinkItem.onDel += DrinkItem_onDel;
                    DrinkItem.onEdit += DrinkItem_onEdit;

                    this.flowLayoutPanelMenu.Controls.Add(DrinkItem);
                }
            }
        }

        private void DeleteMenu(int id)
        {
            DrinkDAL.Instance.DelDrink(id);
        }

        private void SetBackGround()
        {
            bool flag = false;
            foreach (Control control in this.flowLayoutPanelMenu.Controls)
            {
                if (flag == false)
                {
                    control.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                    flag = true;
                }
                else
                {
                    control.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                    flag = false;
                }
            }
        }

        private void DeleteCategoryByName(string name)
        {
            //foreach(MenuItem item in this.flowLayoutPanelMenu.Controls)
            //{
            //    if (item.CATEGORY == name)
            //    {
            //        this.flowLayoutPanelMenu.Controls.Remove(item);
            //    }
            //}
            for (int i = 0; i < this.flowLayoutPanelMenu.Controls.Count; i++)
            {
                if ((this.flowLayoutPanelMenu.Controls[i] as MenuItem).CATEGORY == name)
                {
                    this.flowLayoutPanelMenu.Controls.RemoveAt(i);
                    i--;
                }
            }
        }
        #endregion

        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddDrink fAddDrink = new fAddDrink();
            fAddDrink.onAdd += fAddDrink_onAdd;
            fAddDrink.Tag = fAddDrink;

            fAddDrink.ShowDialog();
        }
        private void fAddDrink_onAdd(object sender, EventArgs e)
        {
            int id = (sender as fAddDrink).ID;
            string name = (sender as fAddDrink).DrinkName;
            int price = (sender as fAddDrink).Price;
            string category = (sender as fAddDrink).Category;
            byte[] image = (sender as fAddDrink).Image;
            int origin = (sender as fAddDrink).Origin;

            MenuItem item = new MenuItem(id, name, price, category, image, true, origin, 0);
            item.onDel += Item_onDel;
            item.onEdit += Item_onEdit;
            item.Tag = item;
            this.flowLayoutPanelMenu.Controls.Add(item);

            //set background
            bool flag = false;
            foreach (MenuItem MenuItem in this.flowLayoutPanelMenu.Controls)
            {
                if (flag == false)
                {
                    MenuItem.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                    MenuItem.TxtCount.BackColor = MenuItem.BtnAdd.BaseColor = MenuItem.BtnShowAddCount.BaseColor = Color.FromArgb(255, 255, 255);
                    flag = true;
                }
                else
                {
                    MenuItem.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                    MenuItem.TxtCount.BackColor = MenuItem.BtnAdd.BaseColor = MenuItem.BtnShowAddCount.BaseColor = Color.FromArgb(240, 240, 240);
                    flag = false;
                }
            }

            this.LoadSize();
        }
        private void Item_onEdit(object sender, EventArgs e)
        {
            int id = int.Parse((sender as MenuItem).ID);
            //string name = (sender as MenuItem).NAME;
            //int price = (sender as MenuItem).PRICE;
            //string category = (sender as MenuItem).CATEGORY;
            //byte[] image = (sender as MenuItem).IMAGE;
            //int origin = (sender as MenuItem).ORIGIN;
            //int count = int.Parse((sender as MenuItem).COUNT);

            Drink drink = DrinkDAL.Instance.GetDrinkByID(id);

            fAddDrink fEditDrink = new fAddDrink(id, drink.Name, drink.Price, drink.Image, drink.OriginPrice, drink.Count);
            //fAddDrink fEditDrink = new fAddDrink(id, name, category, price, image, origin, count);
            //fAddDrink fEditDrink = new fAddDrink(id, name, price, image, origin, count);
            fEditDrink.onEdit += FEditDrink_onEdit;
            fEditDrink.Tag = fEditDrink;

            fEditDrink.ShowDialog();

            (sender as MenuItem).ID = fEditDrink.ID.ToString();
            (sender as MenuItem).NAME = fEditDrink.DrinkName;
            (sender as MenuItem).CATEGORY = DrinkDAL.Instance.GetCategorybyID(fEditDrink.ID);
            (sender as MenuItem).Image = fEditDrink.IMAGE;
            (sender as MenuItem).PRICE = fEditDrink.Price;
            (sender as MenuItem).ORIGIN = fEditDrink.Origin;
            (sender as MenuItem).COUNT = drink.Count.ToString();
        }
        private void Item_onDel(object sender, EventArgs e)
        {
            DrinkDAL.Instance.DelDrink(int.Parse((sender as MenuItem).ID));
            this.flowLayoutPanelMenu.Controls.Remove(sender as MenuItem);

            this.SetBackGround();

            this.LoadSize();
        }

        private void DrinkItem_onEdit(object sender, EventArgs e)
        {
            int id = ((sender as MenuItem).Tag as Drink).ID;
            //string name = ((sender as MenuItem).Tag as Drink).Name;
            //string category = ((sender as MenuItem).Tag as Drink).Category;
            //int price = ((sender as MenuItem).Tag as Drink).Price;
            //byte[] image = ((sender as MenuItem).Tag as Drink).Image;
            //int origin = ((sender as MenuItem).Tag as Drink).OriginPrice;
            //int count = int.Parse((sender as MenuItem).COUNT);

            Drink drink = DrinkDAL.Instance.GetDrinkByID(id);

            fAddDrink fEditDrink = new fAddDrink(id, drink.Name, drink.Price, drink.Image, drink.OriginPrice, drink.Count);
            //fAddDrink fEditDrink = new fAddDrink(id, name, price, image, origin, count);
            fEditDrink.onEdit += FEditDrink_onEdit;
            fEditDrink.Tag = fEditDrink;

            fEditDrink.ShowDialog();

            (sender as MenuItem).ID = fEditDrink.ID.ToString();
            (sender as MenuItem).NAME = fEditDrink.DrinkName;
            (sender as MenuItem).CATEGORY = DrinkDAL.Instance.GetCategorybyID(fEditDrink.ID);
            (sender as MenuItem).Image = fEditDrink.IMAGE;
            (sender as MenuItem).PRICE = fEditDrink.Price;
            (sender as MenuItem).ORIGIN = fEditDrink.Origin;
            (sender as MenuItem).COUNT = drink.Count.ToString();
        }
        private void DrinkItem_onDel(object sender, EventArgs e)
        {
            DrinkDAL.Instance.DelDrink(((sender as MenuItem).Tag as Drink).ID);
            this.flowLayoutPanelMenu.Controls.Remove(sender as MenuItem);

            this.SetBackGround();

            this.LoadSize();
        }

        private void FEditDrink_onEdit(object sender, EventArgs e)
        {
            //this.flowLayoutPanelMenu.Controls.Clear();
            //this.LoadMenu();
            //this.LoadSize();
        }

        private void flowLayoutPanelMenu_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanelMenu.Controls)
            {
                item.Width = flowLayoutPanelMenu.Width;
            }
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            fDelCategory fDelCategory = new fDelCategory();
            fDelCategory.onDel += FDelCategory_onDel;
            fDelCategory.Tag = fDelCategory;

            fDelCategory.ShowDialog();
        }

        private void FDelCategory_onDel(object sender, EventArgs e)
        {
            DeleteCategoryByName((sender as fDelCategory).Category);
            this.SetBackGround();
            this.LoadSize();
            //this.flowLayoutPanelMenu.Controls.Clear();
            //this.LoadMenu();
            //this.LoadSize();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
            this.LoadSize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
            this.LoadSize();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {
            flowLayoutPanelMenu.Controls.Clear();

            this.LoadMenu();
            this.LoadSize();
        }
        #endregion
    }
}