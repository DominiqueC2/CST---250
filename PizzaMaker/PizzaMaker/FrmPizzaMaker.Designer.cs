namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            grpIngredients = new GroupBox();
            chbTomatoes = new CheckBox();
            chbPeppers = new CheckBox();
            chbSausage = new CheckBox();
            chbPineapple = new CheckBox();
            chbMushrooms = new CheckBox();
            chbOlives = new CheckBox();
            chbBacon = new CheckBox();
            chbPepperoni = new CheckBox();
            label2 = new Label();
            lsbStrangeAddOns = new ListBox();
            grpCrust = new GroupBox();
            rdoStuffedCrust = new RadioButton();
            rdoGlutenFree = new RadioButton();
            rdoDeepDish = new RadioButton();
            rdoThinCrust = new RadioButton();
            grpExtraGoodies = new GroupBox();
            lblSauce = new Label();
            label5 = new Label();
            lblCheese = new Label();
            hsbSauce = new HScrollBar();
            label3 = new Label();
            hsbCheese = new HScrollBar();
            dtpDeliveryTime = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            picPizzaBoxColor = new PictureBox();
            label7 = new Label();
            lblPizzaPrice = new Label();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            btnSeeFullOrder = new Button();
            grpIngredients.SuspendLayout();
            grpCrust.SuspendLayout();
            grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaveEH;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Controls.Add(chbPeppers);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(14, 78);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(266, 192);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbTomatoes.Location = new Point(144, 143);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(97, 22);
            chbTomatoes.TabIndex = 7;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeppers.Location = new Point(144, 105);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(85, 22);
            chbPeppers.TabIndex = 6;
            chbPeppers.Text = "Peppers";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbSausage.Location = new Point(144, 68);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(84, 22);
            chbSausage.TabIndex = 5;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPineapple.Location = new Point(144, 30);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(96, 22);
            chbPineapple.TabIndex = 4;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbMushrooms.Location = new Point(12, 143);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(111, 22);
            chbMushrooms.TabIndex = 3;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbOlives.Location = new Point(12, 105);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(71, 22);
            chbOlives.TabIndex = 2;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbBacon.Location = new Point(12, 68);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(69, 22);
            chbBacon.TabIndex = 1;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPepperoni.Location = new Point(12, 30);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(99, 22);
            chbPepperoni.TabIndex = 0;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.UseVisualStyleBackColor = true;
            chbPepperoni.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 273);
            label2.Name = "label2";
            label2.Size = new Size(146, 18);
            label2.TabIndex = 3;
            label2.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.FormattingEnabled = true;
            lsbStrangeAddOns.Items.AddRange(new object[] { "Hotdogs", "Eggplant", "Artichoke Hearts", "Eggs", "Peanut Butter", "Prosciutto", "Honey", "Chili Thread", "Olive Oil", "Arugula", "Garlic", "Chicken", "Anchovies", "BBQ Sauce", "Green Onion", "Red Onion", "Carrots", "Peanuts" });
            lsbStrangeAddOns.Location = new Point(23, 294);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(146, 166);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangedEH;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoStuffedCrust);
            grpCrust.Controls.Add(rdoGlutenFree);
            grpCrust.Controls.Add(rdoDeepDish);
            grpCrust.Controls.Add(rdoThinCrust);
            grpCrust.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(175, 276);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(146, 184);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoStuffedCrust.Location = new Point(13, 109);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(120, 22);
            rdoStuffedCrust.TabIndex = 3;
            rdoStuffedCrust.TabStop = true;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.UseVisualStyleBackColor = true;
            rdoStuffedCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGlutenFree.Location = new Point(13, 147);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(102, 22);
            rdoGlutenFree.TabIndex = 2;
            rdoGlutenFree.TabStop = true;
            rdoGlutenFree.Text = "Thin Crust";
            rdoGlutenFree.UseVisualStyleBackColor = true;
            rdoGlutenFree.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDeepDish.Location = new Point(13, 68);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(97, 22);
            rdoDeepDish.TabIndex = 1;
            rdoDeepDish.TabStop = true;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.UseVisualStyleBackColor = true;
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThinCrust.Location = new Point(13, 28);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(102, 22);
            rdoThinCrust.TabIndex = 0;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // grpExtraGoodies
            // 
            grpExtraGoodies.Controls.Add(lblSauce);
            grpExtraGoodies.Controls.Add(label5);
            grpExtraGoodies.Controls.Add(lblCheese);
            grpExtraGoodies.Controls.Add(hsbSauce);
            grpExtraGoodies.Controls.Add(label3);
            grpExtraGoodies.Controls.Add(hsbCheese);
            grpExtraGoodies.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpExtraGoodies.Location = new Point(23, 466);
            grpExtraGoodies.Name = "grpExtraGoodies";
            grpExtraGoodies.Size = new Size(298, 141);
            grpExtraGoodies.TabIndex = 6;
            grpExtraGoodies.TabStop = false;
            grpExtraGoodies.Text = "Extra Goodies";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(145, 80);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(28, 18);
            lblSauce.TabIndex = 5;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(127, 18);
            label5.TabIndex = 4;
            label5.Text = "Amount of Sauce";
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(148, 22);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(28, 18);
            lblCheese.TabIndex = 3;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(3, 98);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(292, 24);
            hsbSauce.TabIndex = 1;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChangedE;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 2;
            label3.Text = "Amount of Cheese";
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(6, 45);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(289, 23);
            hsbCheese.TabIndex = 0;
            hsbCheese.ValueChanged += HsbExtraGoodiesValueChangedE;
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtpDeliveryTime.Location = new Point(325, 50);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(267, 26);
            dtpDeliveryTime.TabIndex = 7;
            dtpDeliveryTime.ValueChanged += DtpDeliveryTimeValueChangedEH;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(325, 79);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 8;
            label4.Text = "Pizza Box Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(325, 29);
            label6.Name = "label6";
            label6.Size = new Size(123, 18);
            label6.TabIndex = 9;
            label6.Text = "Delivery Time";
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(325, 100);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(232, 68);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(325, 183);
            label7.Name = "label7";
            label7.Size = new Size(106, 18);
            label7.TabIndex = 11;
            label7.Text = "Pizza Price:";
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPizzaPrice.ForeColor = Color.Red;
            lblPizzaPrice.Location = new Point(435, 183);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(27, 18);
            lblPizzaPrice.TabIndex = 12;
            lblPizzaPrice.Text = "$0";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(325, 204);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(106, 23);
            btnResetForm.TabIndex = 13;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += BtnResetFormClickEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(435, 204);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(107, 23);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.TextAlign = ContentAlignment.TopCenter;
            btnCreatePizza.UseVisualStyleBackColor = true;
            btnCreatePizza.Click += BtnCreatePizzaClickEH;
            // 
            // btnSeeFullOrder
            // 
            btnSeeFullOrder.Location = new Point(325, 233);
            btnSeeFullOrder.Name = "btnSeeFullOrder";
            btnSeeFullOrder.Size = new Size(137, 23);
            btnSeeFullOrder.TabIndex = 15;
            btnSeeFullOrder.Text = "See Full Order";
            btnSeeFullOrder.TextAlign = ContentAlignment.TopCenter;
            btnSeeFullOrder.UseVisualStyleBackColor = true;
            btnSeeFullOrder.Click += BtnSeeFullOrderClickEH;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 637);
            Controls.Add(btnSeeFullOrder);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetForm);
            Controls.Add(lblPizzaPrice);
            Controls.Add(label7);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(grpExtraGoodies);
            Controls.Add(grpCrust);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(label2);
            Controls.Add(grpIngredients);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpExtraGoodies.ResumeLayout(false);
            grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox grpIngredients;
        private CheckBox chbPepperoni;
        private CheckBox chbTomatoes;
        private CheckBox chbPeppers;
        private CheckBox chbSausage;
        private CheckBox chbPineapple;
        private CheckBox chbMushrooms;
        private CheckBox chbOlives;
        private CheckBox chbBacon;
        private Label label2;
        private ListBox lsbStrangeAddOns;
        private GroupBox grpCrust;
        private RadioButton rdoStuffedCrust;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoDeepDish;
        private RadioButton rdoThinCrust;
        private GroupBox grpExtraGoodies;
        private HScrollBar hsbSauce;
        private HScrollBar hsbCheese;
        private Label lblSauce;
        private Label label5;
        private Label lblCheese;
        private Label label3;
        private DateTimePicker dtpDeliveryTime;
        private Label label4;
        private Label label6;
        private PictureBox picPizzaBoxColor;
        private Label label7;
        private Label lblPizzaPrice;
        private Button btnResetForm;
        private Button btnCreatePizza;
        private Button btnSeeFullOrder;
    }
}
