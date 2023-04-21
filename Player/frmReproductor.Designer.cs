namespace Player
{
    partial class frmReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.pbxPlay = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(447, 96);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(270, 329);
            this.lbxFiles.TabIndex = 3;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(6, 77);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(414, 200);
            this.MediaPlayer.TabIndex = 0;
            // 
            // pbxRemove
            // 
            this.pbxRemove.Image = global::Player.Properties.Resources.prohibitionroadsign_85736;
            this.pbxRemove.Location = new System.Drawing.Point(647, 393);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(32, 32);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRemove.TabIndex = 6;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Click += new System.EventHandler(this.pbxRemove_Click);
            // 
            // pbxNext
            // 
            this.pbxNext.Image = global::Player.Properties.Resources.Next;
            this.pbxNext.Location = new System.Drawing.Point(262, 375);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(32, 32);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNext.TabIndex = 5;
            this.pbxNext.TabStop = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // pbxPlay
            // 
            this.pbxPlay.Image = global::Player.Properties.Resources.multimediamusicplayerplaybutton_85798;
            this.pbxPlay.Location = new System.Drawing.Point(224, 375);
            this.pbxPlay.Name = "pbxPlay";
            this.pbxPlay.Size = new System.Drawing.Size(32, 32);
            this.pbxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlay.TabIndex = 4;
            this.pbxPlay.TabStop = false;
            this.pbxPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbxAdd.Image = global::Player.Properties.Resources.plusadditionsigncircle_85721;
            this.pbxAdd.Location = new System.Drawing.Point(685, 393);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(32, 32);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 1;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Image = global::Player.Properties.Resources.Back;
            this.pbxBack.Location = new System.Drawing.Point(186, 375);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(32, 32);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBack.TabIndex = 7;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxRemove);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxPlay);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.lbxFiles);
            this.Name = "frmReproductor";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.frmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.PictureBox pbxPlay;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}

