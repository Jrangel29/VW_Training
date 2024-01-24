using System;

namespace Exercise3{

    class PhotobookTest{
        public static void Execute(){
            Photobook defaultPhotobook = new Photobook();
            defaultPhotobook.getNumberPages();

            Photobook photobook = new Photobook();
            photobook.CustomPages(24);
            photobook.getNumberPages();

            BigPhotobook bigPhotobook = new BigPhotobook();
            bigPhotobook.getNumberPages();
        }
        
    }

    class Photobook{
        protected int numPages;

        public Photobook(){
            numPages = 16;
        }

        public void CustomPages(int pages){
            numPages = pages;
        }

        public void getNumberPages(){
            Console.WriteLine($"The photobook has {numPages} pages");
        }
    }

    class BigPhotobook : Photobook{
        public BigPhotobook(){
            numPages = 64;
        }
    }
}