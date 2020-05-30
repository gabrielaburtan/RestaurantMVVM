using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace Restaurant.ViewModels
{
    class Converter
    {
        public List<Image> images = new List<Image>();

        public Converter()
        {
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ardeicopti1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ardeicopti2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\zacusca1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\zacusca2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\fasole1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\fasole2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\slanina1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\slanina2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\carnacior1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\carnacior2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiulet1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiulet2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbaburta1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbaburta2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbavacuta1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbavacuta2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbagaina1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbagaina2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbarosii1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciorbarosii2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciolan1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciolan2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiuletporc1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiuletporc2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\carnegarnita1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\carnegarnita2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pomanaporcului1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pomanaporcului2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cocosel1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cocosel2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\snitelpiure1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\snitelpiure2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ceafaporc1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ceafaporc2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pieptporc1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pieptporc2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cotletporc1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cotletporc2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiuletvita1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\muschiuletvita2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pieptpui1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pieptpui2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pastrama1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\pastrama2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\mici1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\mici2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\varzacalita1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\varzacalita2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\legumegratar1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\legumegratar2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cartofiprajiti1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cartofiprajiti2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cartofitaranesti.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\cartofitaranesti1.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\orezlegume1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\orezlegume2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\papanasi1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\papanasi2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\clatite1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\clatite2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\gogosi1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\gogosi2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\placintamere1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\placintamere2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\poalebrau1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\poalebrau2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\capucino1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\capucino2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciocolatacalda1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ciocolatacalda2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ceai1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\ceai2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\apabucovina1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\apabucovina2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\apaharghita1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\apaharghita2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\fresh1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\fresh2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\limonada1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\limonada2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\beretuborg1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\beretuborg2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\bereguiness1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\bereguiness2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\menupieptporc1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupieptporc2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupieptpui1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupieptpui2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupuiorez1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupuiorez2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupastrama1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniupastrama2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniuzacusca1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniuzacusca2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniumici1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniumici2.jpg"));

            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniuclatite1.jpg"));
            images.Add(Image.FromFile(@"D:\Facultate\Personal\RestaurantMVVM\Restaurant\Restaurant\Resources\ProductImages\meniugogosi2.jpg"));

        }


        public byte[] Convert(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }


        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();

            ImageSource imgSrc = biImg as ImageSource;

            return imgSrc;
        }

    }
}
