using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace ezziresto
{
    public partial class Form_Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BL.User.User user = new BL.User.User();

        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Dashbaord") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               accordionControlDashbaord.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Work period") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionGroupWorkPeriod.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionGroupPos.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               accordionGroupKitchen.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Order Histories") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               accordionControlOrderHistories.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Custommers") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionGroupCustommers.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Credit") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionGroupCredit.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Food Purchase") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionControlFoodPurchase.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Ingredient Purchase") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionControlIngredientPurchase.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               accordionControlAllItems.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionControlGroups.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionControlProperties.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Food Variation") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                accordionControlVariations.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "List Rapport Food Purchase") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                btnFoodPurchase.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                btnPurchaseHistory.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                btnIngredientGroup.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnIngredientItem.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnIngredientPurchase.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnPurchaseIngredientHistory.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnmanageSuppliers.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnSuppliersHistory.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                btnBranches.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnDepartmentTags.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                btnZones.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnTables.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnPaymentTypes.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               barButtonItem2.Enabled = false;//pos
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnNewFoodItem.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnAllFoodItems.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnGroups.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnProperties.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnVariations.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               barButtonItem1.Enabled = false;//work period
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnAdminStaff.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnCustomers.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnWaiters.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnRoleGroups.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnDeliveryUser.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnNewDeliveryUser.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnSettings.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnCurrency.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               btnLanguage.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemBuyRepport.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemSaleRepoort.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemCLients.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemServeur.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemPos.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemWorkPeriod.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemAdmin.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemStock.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemOrders.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemStockRepport.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               tileItemCreditRepport.Enabled = false;
            }

            if (!user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemSupplier.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemDilevery.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemBranches.Enabled = false;
            }

            if (
                !user.check_user_permission(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                tileItemEspace.Enabled = false;
            }

            // groups
            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Manage Stock") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                manageStock.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Restaurant") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                restaurant.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Pos") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                pos.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Foods") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                foods.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Work Period") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
               workPeriod.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "User Management") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                userManagement.Visible = false;
            }

            if (
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Settings") &&
                !user.check_user_permission_group(Properties.Settings.Default.userID, "Admin")
                )
            {
                settings.Visible = false;
            }
        }
        
        private void tileItemPos_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if(user.check_user_permission(Properties.Settings.Default.userID, "Pos"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Pos.Form_Pos pos = new PL.Pos.Form_Pos();
                pos.ShowDialog();
            } else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemCreditRepport_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Credit"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Credit.Form_Credit credit = new PL.Credit.Form_Credit();
                credit.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemSupplier_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Suppliers"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.Supplier.Form_Supplier_List supplier = new PL.Stock.Supplier.Form_Supplier_List();
                supplier.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemCLients_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Customers"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Customer.Form_Customers customers = new PL.Customer.Form_Customers();
                customers.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemServeur_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Waiters"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.Waiter.Form_Waiters_List waiters = new PL.User.Waiter.Form_Waiters_List();
                waiters.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemAdmin_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Users"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.User.Form_Users_List users = new PL.User.User.Form_Users_List();
                users.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemDilevery_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Delivery users"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.DeliveryUser.Form_Delivery_Users_List delivery_user = new PL.User.DeliveryUser.Form_Delivery_Users_List();
                delivery_user.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemBranches_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Branches"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.Branch.Form_Branch_List branchs = new PL.Restaurant.Branch.Form_Branch_List();
                branchs.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemOrders_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Orders"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Order.OrderGroups.Form_Order_Groups orders = new PL.Order.OrderGroups.Form_Order_Groups();
                orders.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemStock_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Kitchen"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Kitchen.Form_kitchen_List kitchen = new PL.Kitchen.Form_kitchen_List();
                kitchen.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemWorkPeriod_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Work periods"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.WorkPeriods.Form_Work_Periods work_periods = new PL.WorkPeriods.Form_Work_Periods();
                work_periods.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Work periods"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.WorkPeriods.Form_Work_Periods work_periods = new PL.WorkPeriods.Form_Work_Periods();
                work_periods.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Pos"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Pos.Form_Pos pos = new PL.Pos.Form_Pos();
                pos.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnNewFoodItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Add food"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Form_Add_New_Item new_item = new PL.Food.Form_Add_New_Item();
                new_item.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnAllFoodItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List foods"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Form_Food_Items_List all_items = new PL.Food.Form_Food_Items_List();
                all_items.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Group"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.FoodGroup.Form_Food_Group group = new PL.Food.FoodGroup.Form_Food_Group();
                group.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Property"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Property.Form_Properties properties = new PL.Food.Property.Form_Properties();
                properties.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnVariations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Variation"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Variation.Form_Variations variations = new PL.Food.Variation.Form_Variations();
                variations.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnFoodPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.FoodPurchase.Form_Add_Food_Purchase food_purchase = new PL.Stock.FoodPurchase.Form_Add_Food_Purchase();
                food_purchase.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnPurchaseHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Food Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.FoodPurchase.Form_Food_Purchase_List food_purchase_list = new PL.Stock.FoodPurchase.Form_Food_Purchase_List();
                food_purchase_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnIngredientGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Ingredient Group"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.IngredientGroup.Form_Ingredient_Group ingredient_group = new PL.Stock.IngredientGroup.Form_Ingredient_Group();
                ingredient_group.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnIngredientItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Ingredient Item"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.IngredientItem.Form_Ingredient_Item ingredient_item = new PL.Stock.IngredientItem.Form_Ingredient_Item();
                ingredient_item.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnIngredientPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Ingredient Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.IngredientPurchase.Form_Add_Ingredient_Purchases ingredient_purchases = new PL.Stock.IngredientPurchase.Form_Add_Ingredient_Purchases();
                ingredient_purchases.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnPurchaseIngredientHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Ingredient Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.IngredientPurchase.Form_Ingredient_Purchases_List ingredient_purchases_List = new PL.Stock.IngredientPurchase.Form_Ingredient_Purchases_List();
                ingredient_purchases_List.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnmanageSuppliers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Supplier"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.Supplier.Form_Supplier_List supplier_list = new PL.Stock.Supplier.Form_Supplier_List();
                supplier_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnSuppliersHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Supplier History"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.SupplierHistory.Form_Supplier_History supplier_history = new PL.Stock.SupplierHistory.Form_Supplier_History();
                supplier_history.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnBranches_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Branches"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.Branch.Form_Branch_List branch_list = new PL.Restaurant.Branch.Form_Branch_List();
                branch_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnDepartmentTags_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Department Tag"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.DepartmentTagList.Form_Department_Tag_List department_tag_list = new PL.Restaurant.DepartmentTagList.Form_Department_Tag_List();
                department_tag_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnZones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Zones"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.Zone.Form_Zones zone_list = new PL.Restaurant.Zone.Form_Zones();
                zone_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnTables_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Tables"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.Table.Form_Table_List table_list = new PL.Restaurant.Table.Form_Table_List();
                table_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnPaymentTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Payment Types"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.PaymentType.Form_Payment_Type payment_type = new PL.Restaurant.PaymentType.Form_Payment_Type();
                payment_type.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnAdminStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Users"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.User.Form_Users_List users_list = new PL.User.User.Form_Users_List();
                users_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Customers"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Customer.Form_Customers customers = new PL.Customer.Form_Customers();
                customers.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnWaiters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Waiters"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.Waiter.Form_Waiters_List waiters = new PL.User.Waiter.Form_Waiters_List();
                waiters.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnRoleGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Permission Group"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.PermissionGroup.Form_Permissions_Group permissions_group = new PL.User.PermissionGroup.Form_Permissions_Group();
                permissions_group.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnDeliveryUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Delivery users"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.DeliveryUser.Form_Delivery_Users_List delivery_users_list = new PL.User.DeliveryUser.Form_Delivery_Users_List();
                delivery_users_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnNewDeliveryUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Delivery users"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.User.DeliveryUser.Form_Delivery_User user_list = new PL.User.DeliveryUser.Form_Delivery_User();
                user_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnLanguage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Language"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Settings.Language.Form_Language_List language_list = new PL.Settings.Language.Form_Language_List();
                language_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Currency"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Settings.Currency.Form_Currency_List currency_list = new PL.Settings.Currency.Form_Currency_List();
                currency_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionGroupWorkPeriod_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Work Periods"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.WorkPeriods.Form_Work_Periods work_periods = new PL.WorkPeriods.Form_Work_Periods();
                work_periods.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionGroupCredit_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Credit"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Credit.Form_Credit credit = new PL.Credit.Form_Credit();
                credit.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionGroupKitchen_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Kitchen"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Kitchen.Form_kitchen_List kitchen = new PL.Kitchen.Form_kitchen_List();
                kitchen.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionGroupCustommers_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Customers"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Customer.Form_Customers customers = new PL.Customer.Form_Customers();
                customers.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlFoodPurchase_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Food Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.FoodPurchase.Form_Food_Purchase_List purchase_list = new PL.Stock.FoodPurchase.Form_Food_Purchase_List();
                purchase_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlIngredientPurchase_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Ingredient Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Stock.IngredientPurchase.Form_Ingredient_Purchases_List purchase_list = new PL.Stock.IngredientPurchase.Form_Ingredient_Purchases_List();
                purchase_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlAllItems_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Food Items"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Form_Food_Items_List food_items_list = new PL.Food.Form_Food_Items_List();
                food_items_list.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlGroups_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Group"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.FoodGroup.Form_Food_Group food_group = new PL.Food.FoodGroup.Form_Food_Group();
                food_group.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlProperties_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Property"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Property.Form_Properties properties = new PL.Food.Property.Form_Properties();
                properties.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlVariations_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Variation"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Variation.Form_Variations variations = new PL.Food.Variation.Form_Variations();
                variations.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Food Variation"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Food.Variation.Form_Variations variations = new PL.Food.Variation.Form_Variations();
                variations.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlOrderHistories_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Order Histories"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Order.Form_Order_Histories order_histories = new PL.Order.Form_Order_Histories();
                order_histories.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionGroupPos_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Pos"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Pos.Form_Pos pos = new PL.Pos.Form_Pos();
                pos.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void accordionControlDashbaord_Click(object sender, EventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Dashbaord"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Dashboard.Form_Dashboard dashbaord = new PL.Dashboard.Form_Dashboard();
                dashbaord.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemBuyRepport_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Rapport Food Purchase"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Rapport.Form_Food_Purchase_List purchase = new PL.Rapport.Form_Food_Purchase_List();
                purchase.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemSaleRepoort_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "List Rapport Order Histories"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Rapport.Form_Order_Histories order = new PL.Rapport.Form_Order_Histories();
                order.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void tileItemEspace_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Tables"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Restaurant.Table.Form_Table_List tables = new PL.Restaurant.Table.Form_Table_List();
                tables.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (user.check_user_permission(Properties.Settings.Default.userID, "Settings"))
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\Added.wav");
                    click.Play();
                }

                PL.Settings.Form_Settings settings = new PL.Settings.Form_Settings();
                settings.ShowDialog();
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer click = new SoundPlayer(@"c:\ValidationError.wav");
                    click.Play();
                }

                MessageBox.Show("You don't have permission to access");
            }
        }
    }
}
