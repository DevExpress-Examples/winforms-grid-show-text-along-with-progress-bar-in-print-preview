using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.XtraPrinting;

namespace WindowsApplication1 {
    public class MyProgressBarControl: ProgressBarControl {
        static MyProgressBarControl() {
            RepositoryItemMyProgressBarControl.RegisterMyProgressBarControl();
        }

        public MyProgressBarControl()
            : base() {
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemMyProgressBarControl.MyProgressBarControlName;
            }
        }
        

        public new RepositoryItemMyProgressBarControl Properties {
            get {
                return (RepositoryItemMyProgressBarControl)base.Properties;
            }
        }

        [UserRepositoryItem("RegisterMyProgressBarControl")]
        public class RepositoryItemMyProgressBarControl: RepositoryItemProgressBar {
            public const string MyProgressBarControlName = "MyProgressBarControl";

            static RepositoryItemMyProgressBarControl() {
                RegisterMyProgressBarControl();
            }
            public override DevExpress.XtraPrinting.IVisualBrick GetBrick(PrintCellHelperInfo info) {
                Bitmap bmp = new Bitmap(info.Rectangle.Width,info.Rectangle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                
                gr.FillRectangle(new SolidBrush(Color.White),info.Rectangle);
                ImageBrick brick = new ImageBrick(BorderSide.None,0,Color.Transparent,Color.Transparent);
                int width =Convert.ToInt32(info.Rectangle.Width * Convert.ToDouble(info.EditValue)/((double)100));
                if(width > 0) {
                    gr.FillRectangle(new LinearGradientBrush(new Rectangle(0,0,width,info.Rectangle.Height),Color.LightBlue,Color.White,90,true),new Rectangle(0,0,width,info.Rectangle.Height));
                    brick.Image = bmp;
                }
                gr.DrawString(info.DisplayText,info.Appearace.Font,new SolidBrush(Color.Black),new PointF(0,0));
                brick.Rect = info.Rectangle;
                return brick;
            }
            public RepositoryItemMyProgressBarControl()
                : base() {
            }

            public override string EditorTypeName {
                get {
                    return MyProgressBarControlName;
                }
            }

            public static void RegisterMyProgressBarControl() {
                EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyProgressBarControlName,typeof(MyProgressBarControl),typeof(RepositoryItemMyProgressBarControl),typeof(MyProgressBarViewInfo),new ProgressBarPainter(),true));
            }
        }

        public class MyProgressBarViewInfo: ProgressBarViewInfo {
            public MyProgressBarViewInfo(RepositoryItem item)
                : base(item) {
            }
        }
    }
}
