using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WHeditor
{
    public static class ScreenShot
    {
        public static void CaptureScreen(UIElement source, Uri destination)
        {
            try
            {
                double Height, renderHeight, Width, renderWidth;

                Height = renderHeight = source.RenderSize.Height;
                Width = renderWidth = source.RenderSize.Width;

                
                RenderTargetBitmap renderTarget = new RenderTargetBitmap((int)renderWidth, (int)renderHeight, 96, 96, PixelFormats.Pbgra32);
              
                VisualBrush visualBrush = new VisualBrush(source);

                DrawingVisual drawingVisual = new DrawingVisual();
                using (DrawingContext drawingContext = drawingVisual.RenderOpen())
                {

                    drawingContext.DrawRectangle(visualBrush, null, new Rect(new Point(0, 0), new Point(Width, Height)));
                }

                renderTarget.Render(drawingVisual);

                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(renderTarget));
                using (FileStream stream = new FileStream(destination.LocalPath, FileMode.Create, FileAccess.Write))
                {
                    encoder.Save(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //public static void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Set scrollviewer's Content property as UI element to capture full content
        //    UIElement element = scrollViewer.Content as UIElement;
        //    Uri path = new Uri(@"D:\SS\screenshot.png");
        //    CaptureScreen(element, path);
        //}

    }
}
