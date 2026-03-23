namespace PizzaMaker
{
    partial class FrmOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrderDetails = new Label();
            btnSaveOrder = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDetails.Location = new Point(23, 33);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(84, 15);
            lblOrderDetails.TabIndex = 0;
            lblOrderDetails.Text = "Order Details";
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveOrder.Location = new Point(622, 374);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(84, 23);
            btnSaveOrder.TabIndex = 16;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.TextAlign = ContentAlignment.TopCenter;
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += BtnSaveOrderClickEH;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(43, 374);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(84, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBackClickEH;
            // 
            // FrmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSaveOrder);
            Controls.Add(lblOrderDetails);
            Name = "FrmOrderDetails";
            Text = "Pizza Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDetails;
        private Button btnSaveOrder;
        private Button btnBack;
    }
}