namespace PowerPoint.AddIn
{
    partial class RemoteControlForm
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
            this._prev = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._stop = new System.Windows.Forms.Button();
            this._notes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _prev
            // 
            this._prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._prev.Font = new System.Drawing.Font("Webdings", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._prev.Location = new System.Drawing.Point(140, 363);
            this._prev.Name = "_prev";
            this._prev.Size = new System.Drawing.Size(40, 40);
            this._prev.TabIndex = 0;
            this._prev.Text = "3";
            this._prev.UseVisualStyleBackColor = true;
            this._prev.Click += new System.EventHandler(this.OnPrev);
            // 
            // _next
            // 
            this._next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._next.Font = new System.Drawing.Font("Webdings", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._next.Location = new System.Drawing.Point(232, 363);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(40, 40);
            this._next.TabIndex = 2;
            this._next.Text = "4";
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this.OnNext);
            // 
            // _stop
            // 
            this._stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._stop.Font = new System.Drawing.Font("Webdings", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this._stop.Location = new System.Drawing.Point(186, 363);
            this._stop.Name = "_stop";
            this._stop.Size = new System.Drawing.Size(40, 40);
            this._stop.TabIndex = 1;
            this._stop.Text = "<";
            this._stop.UseVisualStyleBackColor = true;
            this._stop.Click += new System.EventHandler(this.OnStop);
            // 
            // _notes
            // 
            this._notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._notes.Location = new System.Drawing.Point(13, 13);
            this._notes.Multiline = true;
            this._notes.Name = "_notes";
            this._notes.Size = new System.Drawing.Size(401, 344);
            this._notes.TabIndex = 3;
            // 
            // RemoteControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 415);
            this.ControlBox = false;
            this.Controls.Add(this._notes);
            this.Controls.Add(this._stop);
            this.Controls.Add(this._next);
            this.Controls.Add(this._prev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _prev;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.Button _stop;
        private System.Windows.Forms.TextBox _notes;
    }
}