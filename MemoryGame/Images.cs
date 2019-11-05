using System;
using System.Collections.Generic;
using System.Drawing;

namespace MemoryGame
{
    class Images
    {
        // Το prism είναι το πίσω μέρος όλων των κουμπιών
        public Image prism = Image.FromFile("prism.png");

        //Η λίστα που περιέχει όλες τις εικόνες που θα έχουν τα κουμπιά
        public List<Image> images = new List<Image>();
        public Images() {
            images.Add(Image.FromFile("ImageSet3/1.png"));
            images.Add(Image.FromFile("ImageSet3/2.png"));
            images.Add(Image.FromFile("ImageSet3/3.png"));
            images.Add(Image.FromFile("ImageSet3/4.png"));
            images.Add(Image.FromFile("ImageSet3/5.png"));
            images.Add(Image.FromFile("ImageSet3/6.png"));
            images.Add(Image.FromFile("ImageSet3/7.png"));
            images.Add(Image.FromFile("ImageSet3/8.png"));
            images.Add(Image.FromFile("ImageSet3/9.png"));
            images.Add(Image.FromFile("ImageSet3/10.png"));
            images.Add(Image.FromFile("ImageSet3/11.png"));
            images.Add(Image.FromFile("ImageSet3/12.png"));
        }
        Image[] copy = new Image[12];
        Random r1 = new Random();
        int n = 11;
        public void randomizeimages()
        {
            // Icons are transfered randomly from the list to the array.
            for (int i = 0; i < 12; i++)
            {
                int randomindex = r1.Next(0, n);
                copy[i] = images[randomindex];
                images.RemoveAt(randomindex);
                n--;
            }
            // Icons are transfered back to the list.
            // Their position now is different, in a dandom way.
            for (int i = 0; i < 12; i++)
            {
                images.Add(copy[i]);
            }
            n = 11;
        }
    }
}
