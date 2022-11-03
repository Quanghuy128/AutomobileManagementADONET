﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutomobileLibrary.Repository;
using AutomobileLibrary.BusinessObject;
namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // true is insert / false is update
        public Car CarInfo { get; set; }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedItem = 0;
            txtCarID.Enabled = !InsertOrUpdate; 
            if(InsertOrUpdate == true)
            {
                //Show car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        } //end frmCarDetails_Load

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void cboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void lbReleaseYear_Click(object sender, EventArgs e)
        {

        }

        private void txtCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //assign form value to car object
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text),
                };
                
                if(InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
