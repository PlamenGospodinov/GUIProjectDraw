using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GUIProjectDraw.src.Model;

namespace GUIProjectDraw.src.Processors
{

    /// <summary>
    /// Класът, който ще бъде използван при управляване на дисплейната система.
    /// </summary>
    public class DisplayProcessor
    {
        #region Constructor

        public DisplayProcessor()
        {
        }

        #endregion

        #region Properties
        /// <summary>
		/// Списък с всички елементи формиращи изображението.
		/// </summary>
        private List<Shape> shapeList = new List<Shape>();
        public List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }

        #endregion
        #region Drawing

        /// <summary>
        /// Прерисува всички елементи в shapeList върху e.Graphics
        /// </summary>
        public void ReDraw(object sender,PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Draw(e.Graphics);
        }

        /// <summary>
		/// Визуализация.
		/// Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
		/// </summary>
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		public virtual void Draw(Graphics grfx)
        {
            foreach (Shape item in ShapeList)
            {
                DrawShape(grfx, item);
            }
        }

        /// <summary>
		/// Визуализира даден елемент от изображението.
		/// </summary>
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		/// <param name="item">Елемент за визуализиране.</param>
		public virtual void DrawShape(Graphics grfx, Shape item)
        {
            item.DrawSelf(grfx);
        }

        #endregion
    }
}
