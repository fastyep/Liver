namespace Liver
{
    partial class Explorer
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
	        this.components = new System.ComponentModel.Container();
	        this.filesView = new System.Windows.Forms.ListView();
	        this.collagePanel = new System.Windows.Forms.Panel();
	        this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
	        this.оценкиИКомментарииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.лентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.коллажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
	        this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.mainMenu = new System.Windows.Forms.MenuStrip();
	        this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	        this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.скопироватьВБуферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.дискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	        this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	        this.средстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.комментарииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.лентаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	        this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.плиточкойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.табличкойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.коллажикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.filesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
	        this.переименоватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
	        this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
	        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
	        this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	        this.переименоватьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
	        this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
	        this.collageContext = new System.Windows.Forms.ContextMenuStrip(this.components);
	        this.сохранитьКакToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	        this.fileContextMenu.SuspendLayout();
	        this.mainMenu.SuspendLayout();
	        this.filesContext.SuspendLayout();
	        this.collageContext.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // filesView
	        // 
	        this.filesView.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.filesView.HideSelection = false;
	        this.filesView.Location = new System.Drawing.Point(0, 24);
	        this.filesView.Name = "filesView";
	        this.filesView.Size = new System.Drawing.Size(801, 427);
	        this.filesView.TabIndex = 0;
	        this.filesView.UseCompatibleStateImageBehavior = false;
	        this.filesView.DoubleClick += new System.EventHandler(this.filesView_DoubleClick);
	        this.filesView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesView_MouseClick);
	        // 
	        // collagePanel
	        // 
	        this.collagePanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.collagePanel.BackColor = System.Drawing.Color.White;
	        this.collagePanel.Location = new System.Drawing.Point(0, 24);
	        this.collagePanel.Name = "collagePanel";
	        this.collagePanel.Size = new System.Drawing.Size(800, 427);
	        this.collagePanel.TabIndex = 2;
	        this.collagePanel.Visible = false;
	        this.collagePanel.SizeChanged += new System.EventHandler(this.collagePanel_SizeChanged);
	        this.collagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.collagePanel_Paint);
	        this.collagePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.collagePanel_MouseClick);
	        this.collagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.collagePanel_MouseMove);
	        // 
	        // fileContextMenu
	        // 
	        this.fileContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
	        this.fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.оценкиИКомментарииToolStripMenuItem, this.лентаToolStripMenuItem, this.коллажToolStripMenuItem, this.toolStripSeparator1, this.открытьToolStripMenuItem, this.переименоватьToolStripMenuItem, this.удалитьToolStripMenuItem});
	        this.fileContextMenu.Name = "fileContextMenu";
	        this.fileContextMenu.Size = new System.Drawing.Size(162, 142);
	        // 
	        // оценкиИКомментарииToolStripMenuItem
	        // 
	        this.оценкиИКомментарииToolStripMenuItem.Name = "оценкиИКомментарииToolStripMenuItem";
	        this.оценкиИКомментарииToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.оценкиИКомментарииToolStripMenuItem.Text = "Комментарии";
	        this.оценкиИКомментарииToolStripMenuItem.Click += new System.EventHandler(this.commentsMenuItem_Click);
	        // 
	        // лентаToolStripMenuItem
	        // 
	        this.лентаToolStripMenuItem.Name = "лентаToolStripMenuItem";
	        this.лентаToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.лентаToolStripMenuItem.Text = "Лента";
	        // 
	        // коллажToolStripMenuItem
	        // 
	        this.коллажToolStripMenuItem.Name = "коллажToolStripMenuItem";
	        this.коллажToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.коллажToolStripMenuItem.Text = "Коллаж";
	        // 
	        // toolStripSeparator1
	        // 
	        this.toolStripSeparator1.Name = "toolStripSeparator1";
	        this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
	        // 
	        // открытьToolStripMenuItem
	        // 
	        this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
	        this.открытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.открытьToolStripMenuItem.Text = "Редактировать";
	        // 
	        // переименоватьToolStripMenuItem
	        // 
	        this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
	        this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.переименоватьToolStripMenuItem.Text = "Переименовать";
	        // 
	        // удалитьToolStripMenuItem
	        // 
	        this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
	        this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.удалитьToolStripMenuItem.Text = "Удалить";
	        // 
	        // mainMenu
	        // 
	        this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
	        this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.файлToolStripMenuItem, this.дискиToolStripMenuItem, this.правкаToolStripMenuItem, this.средстваToolStripMenuItem, this.видToolStripMenuItem, this.настройкиToolStripMenuItem, this.оПрограммеToolStripMenuItem});
	        this.mainMenu.Location = new System.Drawing.Point(0, 0);
	        this.mainMenu.Name = "mainMenu";
	        this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
	        this.mainMenu.Size = new System.Drawing.Size(800, 24);
	        this.mainMenu.TabIndex = 4;
	        this.mainMenu.Text = "menuStrip1";
	        // 
	        // файлToolStripMenuItem
	        // 
	        this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.открытьToolStripMenuItem1, this.сохранитьКакToolStripMenuItem, this.скопироватьВБуферToolStripMenuItem});
	        this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
	        this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
	        this.файлToolStripMenuItem.Text = "Файл";
	        // 
	        // открытьToolStripMenuItem1
	        // 
	        this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
	        this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
	        this.открытьToolStripMenuItem1.Text = "Открыть";
	        // 
	        // сохранитьКакToolStripMenuItem
	        // 
	        this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
	        this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
	        this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
	        // 
	        // скопироватьВБуферToolStripMenuItem
	        // 
	        this.скопироватьВБуферToolStripMenuItem.Name = "скопироватьВБуферToolStripMenuItem";
	        this.скопироватьВБуферToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
	        this.скопироватьВБуферToolStripMenuItem.Text = "Скопировать в буфер";
	        // 
	        // дискиToolStripMenuItem
	        // 
	        this.дискиToolStripMenuItem.Name = "дискиToolStripMenuItem";
	        this.дискиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
	        this.дискиToolStripMenuItem.Text = "Диски";
	        this.дискиToolStripMenuItem.Click += new System.EventHandler(this.drivesMainMenu_Click);
	        // 
	        // правкаToolStripMenuItem
	        // 
	        this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.переименоватьToolStripMenuItem1, this.удалитьToolStripMenuItem1});
	        this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
	        this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
	        this.правкаToolStripMenuItem.Text = "Правка";
	        // 
	        // переименоватьToolStripMenuItem1
	        // 
	        this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
	        this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
	        this.переименоватьToolStripMenuItem1.Text = "Переименовать";
	        this.переименоватьToolStripMenuItem1.Click += new System.EventHandler(this.переименоватьToolStripMenuItem1_Click);
	        // 
	        // удалитьToolStripMenuItem1
	        // 
	        this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
	        this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
	        this.удалитьToolStripMenuItem1.Text = "Удалить";
	        this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
	        // 
	        // средстваToolStripMenuItem
	        // 
	        this.средстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.комментарииToolStripMenuItem, this.лентаToolStripMenuItem1});
	        this.средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
	        this.средстваToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
	        this.средстваToolStripMenuItem.Text = "Средства";
	        // 
	        // комментарииToolStripMenuItem
	        // 
	        this.комментарииToolStripMenuItem.Name = "комментарииToolStripMenuItem";
	        this.комментарииToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
	        this.комментарииToolStripMenuItem.Text = "Комментарии";
	        this.комментарииToolStripMenuItem.Click += new System.EventHandler(this.commentsMenuItem_Click);
	        // 
	        // лентаToolStripMenuItem1
	        // 
	        this.лентаToolStripMenuItem1.Name = "лентаToolStripMenuItem1";
	        this.лентаToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
	        this.лентаToolStripMenuItem1.Text = "Лента";
	        this.лентаToolStripMenuItem1.Click += new System.EventHandler(this.lentaMenuItem_Click);
	        // 
	        // видToolStripMenuItem
	        // 
	        this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.плиточкойToolStripMenuItem, this.табличкойToolStripMenuItem, this.коллажикомToolStripMenuItem});
	        this.видToolStripMenuItem.Name = "видToolStripMenuItem";
	        this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
	        this.видToolStripMenuItem.Text = "Вид";
	        // 
	        // плиточкойToolStripMenuItem
	        // 
	        this.плиточкойToolStripMenuItem.Name = "плиточкойToolStripMenuItem";
	        this.плиточкойToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
	        this.плиточкойToolStripMenuItem.Text = "Плиточкой";
	        this.плиточкойToolStripMenuItem.Click += new System.EventHandler(this.iconsMainMenu_Click);
	        // 
	        // табличкойToolStripMenuItem
	        // 
	        this.табличкойToolStripMenuItem.Name = "табличкойToolStripMenuItem";
	        this.табличкойToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
	        this.табличкойToolStripMenuItem.Text = "Табличкой";
	        this.табличкойToolStripMenuItem.Click += new System.EventHandler(this.tableMainMenu_Click);
	        // 
	        // коллажикомToolStripMenuItem
	        // 
	        this.коллажикомToolStripMenuItem.Name = "коллажикомToolStripMenuItem";
	        this.коллажикомToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
	        this.коллажикомToolStripMenuItem.Text = "Коллажиком";
	        this.коллажикомToolStripMenuItem.Click += new System.EventHandler(this.collageMainMenu_Click);
	        // 
	        // настройкиToolStripMenuItem
	        // 
	        this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
	        this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
	        this.настройкиToolStripMenuItem.Text = "Настройки";
	        this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.settingsMainMenu_Click);
	        // 
	        // оПрограммеToolStripMenuItem
	        // 
	        this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
	        this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
	        this.оПрограммеToolStripMenuItem.Text = "О программе";
	        this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
	        // 
	        // filesContext
	        // 
	        this.filesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.переименоватьToolStripMenuItem2, this.удалитьToolStripMenuItem2, this.toolStripSeparator2, this.редактироватьToolStripMenuItem, this.переименоватьToolStripMenuItem3, this.удалитьToolStripMenuItem3});
	        this.filesContext.Name = "filesContext";
	        this.filesContext.Size = new System.Drawing.Size(162, 120);
	        // 
	        // переименоватьToolStripMenuItem2
	        // 
	        this.переименоватьToolStripMenuItem2.Name = "переименоватьToolStripMenuItem2";
	        this.переименоватьToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
	        this.переименоватьToolStripMenuItem2.Text = "Комментарии";
	        this.переименоватьToolStripMenuItem2.Click += new System.EventHandler(this.commentsMenuItem_Click);
	        // 
	        // удалитьToolStripMenuItem2
	        // 
	        this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
	        this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
	        this.удалитьToolStripMenuItem2.Text = "Лента";
	        this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.lentaMenuItem_Click);
	        // 
	        // toolStripSeparator2
	        // 
	        this.toolStripSeparator2.Name = "toolStripSeparator2";
	        this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
	        // 
	        // редактироватьToolStripMenuItem
	        // 
	        this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
	        this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
	        this.редактироватьToolStripMenuItem.Text = "Редактировать";
	        this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
	        // 
	        // переименоватьToolStripMenuItem3
	        // 
	        this.переименоватьToolStripMenuItem3.Name = "переименоватьToolStripMenuItem3";
	        this.переименоватьToolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
	        this.переименоватьToolStripMenuItem3.Text = "Переименовать";
	        this.переименоватьToolStripMenuItem3.Click += new System.EventHandler(this.переименоватьToolStripMenuItem1_Click);
	        // 
	        // удалитьToolStripMenuItem3
	        // 
	        this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
	        this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
	        this.удалитьToolStripMenuItem3.Text = "Удалить";
	        this.удалитьToolStripMenuItem3.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
	        // 
	        // collageContext
	        // 
	        this.collageContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.сохранитьКакToolStripMenuItem1});
	        this.collageContext.Name = "collageContext";
	        this.collageContext.Size = new System.Drawing.Size(155, 26);
	        // 
	        // сохранитьКакToolStripMenuItem1
	        // 
	        this.сохранитьКакToolStripMenuItem1.Name = "сохранитьКакToolStripMenuItem1";
	        this.сохранитьКакToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
	        this.сохранитьКакToolStripMenuItem1.Text = "Сохранить как";
	        this.сохранитьКакToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem1_Click);
	        // 
	        // Explorer
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.BackColor = System.Drawing.SystemColors.Control;
	        this.ClientSize = new System.Drawing.Size(800, 450);
	        this.Controls.Add(this.mainMenu);
	        this.Controls.Add(this.collagePanel);
	        this.Controls.Add(this.filesView);
	        this.Location = new System.Drawing.Point(15, 15);
	        this.Name = "Explorer";
	        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	        this.Text = "Проводник";
	        this.fileContextMenu.ResumeLayout(false);
	        this.mainMenu.ResumeLayout(false);
	        this.mainMenu.PerformLayout();
	        this.filesContext.ResumeLayout(false);
	        this.collageContext.ResumeLayout(false);
	        this.ResumeLayout(false);
	        this.PerformLayout();
        }

        private System.Windows.Forms.ContextMenuStrip collageContext;
        private System.Windows.Forms.Panel collagePanel;
        private System.Windows.Forms.ContextMenuStrip fileContextMenu;
        private System.Windows.Forms.ContextMenuStrip filesContext;
        private System.Windows.Forms.ListView filesView;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллажикомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комментарииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лентаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оценкиИКомментарииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem плиточкойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьВБуферToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem средстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табличкойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;

        #endregion
    }
}