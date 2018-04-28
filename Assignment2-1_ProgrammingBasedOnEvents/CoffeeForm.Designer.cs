namespace Assignment2_1_ProgrammingBasedOnEvents
{
    partial class CoffeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeForm));
            this.MenuTitle = new System.Windows.Forms.Label();
            this.coffeePrices = new System.Windows.Forms.Label();
            this.flavorsHeading = new System.Windows.Forms.Label();
            this.flavorsList = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.iceHotBox = new System.Windows.Forms.GroupBox();
            this.icedRadio = new System.Windows.Forms.RadioButton();
            this.hotRadio = new System.Windows.Forms.RadioButton();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.finalButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.qtyNflavorBox = new System.Windows.Forms.GroupBox();
            this.flavorsDrop = new System.Windows.Forms.ComboBox();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.medRadio = new System.Windows.Forms.RadioButton();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.receiptBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.iceHotBox.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.qtyNflavorBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.MenuTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuTitle.Location = new System.Drawing.Point(40, 9);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(79, 24);
            this.MenuTitle.TabIndex = 0;
            this.MenuTitle.Text = "Menu:";
            // 
            // coffeePrices
            // 
            this.coffeePrices.AutoSize = true;
            this.coffeePrices.BackColor = System.Drawing.Color.Transparent;
            this.coffeePrices.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeePrices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.coffeePrices.Location = new System.Drawing.Point(12, 46);
            this.coffeePrices.Name = "coffeePrices";
            this.coffeePrices.Size = new System.Drawing.Size(148, 85);
            this.coffeePrices.TabIndex = 1;
            this.coffeePrices.Text = "Small 8oz.    $1.00\n\nMedium 12oz.   $1.50\n\nLarge  16oz.   $2.00;";
            // 
            // flavorsHeading
            // 
            this.flavorsHeading.AutoSize = true;
            this.flavorsHeading.BackColor = System.Drawing.Color.Transparent;
            this.flavorsHeading.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavorsHeading.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.flavorsHeading.Location = new System.Drawing.Point(12, 150);
            this.flavorsHeading.Name = "flavorsHeading";
            this.flavorsHeading.Size = new System.Drawing.Size(65, 17);
            this.flavorsHeading.TabIndex = 3;
            this.flavorsHeading.Text = "Flavors:";
            // 
            // flavorsList
            // 
            this.flavorsList.AutoSize = true;
            this.flavorsList.BackColor = System.Drawing.Color.Transparent;
            this.flavorsList.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavorsList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.flavorsList.Location = new System.Drawing.Point(12, 177);
            this.flavorsList.Name = "flavorsList";
            this.flavorsList.Size = new System.Drawing.Size(163, 153);
            this.flavorsList.TabIndex = 4;
            this.flavorsList.Text = "Black (aka None)\n Mocha\nHazelnut\nVanilla\nMint\nRaspberry\nRasberry Mint Mocha\nMocha" +
    " Mint\nMocha Vanilla";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.orderLabel.Location = new System.Drawing.Point(248, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(81, 24);
            this.orderLabel.TabIndex = 5;
            this.orderLabel.Text = "Order:";
            // 
            // iceHotBox
            // 
            this.iceHotBox.BackColor = System.Drawing.Color.Transparent;
            this.iceHotBox.Controls.Add(this.icedRadio);
            this.iceHotBox.Controls.Add(this.hotRadio);
            this.iceHotBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceHotBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iceHotBox.Location = new System.Drawing.Point(3, 3);
            this.iceHotBox.Name = "iceHotBox";
            this.iceHotBox.Size = new System.Drawing.Size(186, 55);
            this.iceHotBox.TabIndex = 6;
            this.iceHotBox.TabStop = false;
            this.iceHotBox.Text = "Pick one:";
            // 
            // icedRadio
            // 
            this.icedRadio.AutoSize = true;
            this.icedRadio.Location = new System.Drawing.Point(115, 22);
            this.icedRadio.Name = "icedRadio";
            this.icedRadio.Size = new System.Drawing.Size(55, 21);
            this.icedRadio.TabIndex = 1;
            this.icedRadio.TabStop = true;
            this.icedRadio.Text = "Iced";
            this.icedRadio.UseVisualStyleBackColor = true;
            this.icedRadio.CheckedChanged += new System.EventHandler(this.HotCold_CheckChanged);
            // 
            // hotRadio
            // 
            this.hotRadio.AutoSize = true;
            this.hotRadio.Location = new System.Drawing.Point(7, 22);
            this.hotRadio.Name = "hotRadio";
            this.hotRadio.Size = new System.Drawing.Size(53, 21);
            this.hotRadio.TabIndex = 0;
            this.hotRadio.TabStop = true;
            this.hotRadio.Text = "Hot";
            this.hotRadio.UseVisualStyleBackColor = true;
            this.hotRadio.CheckedChanged += new System.EventHandler(this.HotCold_CheckChanged);
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.Transparent;
            this.orderPanel.Controls.Add(this.finalButton);
            this.orderPanel.Controls.Add(this.addButton);
            this.orderPanel.Controls.Add(this.qtyNflavorBox);
            this.orderPanel.Controls.Add(this.sizeBox);
            this.orderPanel.Controls.Add(this.iceHotBox);
            this.orderPanel.Location = new System.Drawing.Point(197, 36);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(396, 459);
            this.orderPanel.TabIndex = 7;
            // 
            // finalButton
            // 
            this.finalButton.BackColor = System.Drawing.Color.Tan;
            this.finalButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalButton.Location = new System.Drawing.Point(208, 408);
            this.finalButton.Name = "finalButton";
            this.finalButton.Size = new System.Drawing.Size(178, 48);
            this.finalButton.TabIndex = 10;
            this.finalButton.Text = "Finalize Order";
            this.finalButton.UseVisualStyleBackColor = false;
            this.finalButton.Click += new System.EventHandler(this.finalButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Tan;
            this.addButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(4, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(185, 48);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add to Order";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // qtyNflavorBox
            // 
            this.qtyNflavorBox.BackColor = System.Drawing.Color.Transparent;
            this.qtyNflavorBox.Controls.Add(this.flavorsDrop);
            this.qtyNflavorBox.Controls.Add(this.flavorLabel);
            this.qtyNflavorBox.Controls.Add(this.qtyLabel);
            this.qtyNflavorBox.Controls.Add(this.qtyTextBox);
            this.qtyNflavorBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyNflavorBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.qtyNflavorBox.Location = new System.Drawing.Point(208, 3);
            this.qtyNflavorBox.Name = "qtyNflavorBox";
            this.qtyNflavorBox.Size = new System.Drawing.Size(178, 142);
            this.qtyNflavorBox.TabIndex = 8;
            this.qtyNflavorBox.TabStop = false;
            // 
            // flavorsDrop
            // 
            this.flavorsDrop.BackColor = System.Drawing.Color.Tan;
            this.flavorsDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavorsDrop.FormattingEnabled = true;
            this.flavorsDrop.Items.AddRange(new object[] {
            "Black",
            "Mocha",
            "Hazelnut",
            "Vanilla",
            "Mint",
            "Raspberry",
            "Rasberry Mint Mocha",
            "Mocha Mint",
            "Mocha Vanilla"});
            this.flavorsDrop.Location = new System.Drawing.Point(6, 103);
            this.flavorsDrop.Name = "flavorsDrop";
            this.flavorsDrop.Size = new System.Drawing.Size(163, 25);
            this.flavorsDrop.TabIndex = 3;
            this.flavorsDrop.SelectedIndexChanged += new System.EventHandler(this.flavorsDrop_SelectedIndexChanged);
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.BackColor = System.Drawing.Color.Transparent;
            this.flavorLabel.Location = new System.Drawing.Point(4, 75);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(105, 17);
            this.flavorLabel.TabIndex = 2;
            this.flavorLabel.Text = "What Flavor?";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.qtyLabel.Location = new System.Drawing.Point(3, 23);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(94, 17);
            this.qtyLabel.TabIndex = 0;
            this.qtyLabel.Text = "How Many?";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BackColor = System.Drawing.Color.Tan;
            this.qtyTextBox.Location = new System.Drawing.Point(114, 15);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(55, 25);
            this.qtyTextBox.TabIndex = 1;
            this.qtyTextBox.TextChanged += new System.EventHandler(this.qtyTextBox_TextChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.Color.Transparent;
            this.sizeBox.Controls.Add(this.largeRadio);
            this.sizeBox.Controls.Add(this.medRadio);
            this.sizeBox.Controls.Add(this.smallRadio);
            this.sizeBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sizeBox.Location = new System.Drawing.Point(4, 65);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(185, 80);
            this.sizeBox.TabIndex = 7;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size:";
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Location = new System.Drawing.Point(113, 20);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(66, 21);
            this.largeRadio.TabIndex = 2;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large";
            this.largeRadio.UseVisualStyleBackColor = true;
            this.largeRadio.CheckedChanged += new System.EventHandler(this.Size_CheckChanged);
            // 
            // medRadio
            // 
            this.medRadio.AutoSize = true;
            this.medRadio.Location = new System.Drawing.Point(44, 47);
            this.medRadio.Name = "medRadio";
            this.medRadio.Size = new System.Drawing.Size(84, 21);
            this.medRadio.TabIndex = 1;
            this.medRadio.TabStop = true;
            this.medRadio.Text = "Medium";
            this.medRadio.UseVisualStyleBackColor = true;
            this.medRadio.CheckedChanged += new System.EventHandler(this.Size_CheckChanged);
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Location = new System.Drawing.Point(7, 22);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(64, 21);
            this.smallRadio.TabIndex = 0;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small";
            this.smallRadio.UseVisualStyleBackColor = true;
            this.smallRadio.CheckedChanged += new System.EventHandler(this.Size_CheckChanged);
            // 
            // receiptBox
            // 
            this.receiptBox.BackColor = System.Drawing.Color.Tan;
            this.receiptBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBox.Location = new System.Drawing.Point(613, 16);
            this.receiptBox.Multiline = true;
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.ReadOnly = true;
            this.receiptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiptBox.Size = new System.Drawing.Size(162, 192);
            this.receiptBox.TabIndex = 8;
            this.receiptBox.Text = "Receipt:\n";
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Tan;
            this.newButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(613, 444);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(162, 48);
            this.newButton.TabIndex = 11;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tan;
            this.exitButton.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(162, 48);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2_1_ProgrammingBasedOnEvents.Properties.Resources.coffeeBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptBox);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.flavorsList);
            this.Controls.Add(this.flavorsHeading);
            this.Controls.Add(this.coffeePrices);
            this.Controls.Add(this.MenuTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CoffeeForm";
            this.Text = "Coffee House";
            this.iceHotBox.ResumeLayout(false);
            this.iceHotBox.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.qtyNflavorBox.ResumeLayout(false);
            this.qtyNflavorBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Label coffeePrices;
        private System.Windows.Forms.Label flavorsHeading;
        private System.Windows.Forms.Label flavorsList;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.GroupBox iceHotBox;
        private System.Windows.Forms.RadioButton icedRadio;
        private System.Windows.Forms.RadioButton hotRadio;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.RadioButton medRadio;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.GroupBox qtyNflavorBox;
        private System.Windows.Forms.ComboBox flavorsDrop;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.Button finalButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox receiptBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button exitButton;
    }
}

