#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include "imglib.h" 

#define RED_C 0
#define GREEN_C 1
#define BLUE_C 2
#define GET_PIXEL(IMG, X, Y) ((IMG)->buf[ (Y) * (IMG)->width + (X) ])
#define MAXCMDBUF 100
#define MAXFILENAMELEN 256
#define MAXFULLCMDBUF (MAXCMDBUF + MAXFILENAMELEN)
#define PPMREADBUFLEN 256


int main(int argc, char **argv)
{
   image im1, im2;
   double totalDiff = 0.0;
   unsigned int x, y;

   if ( argc < 3 )
   {
      fprintf(stderr, "usage:\n%s FILE1 FILE2\n", argv[0]);
      exit(1);
   }
   im1 = read_image(argv[1]);
   if ( im1 == NULL ) exit(1);
   im2 = read_image(argv[2]);
   if ( im2 == NULL ) { free_img(im1); exit(1); }
   if ( (im1->width != im2->width) || (im1->height != im2->height) )
   {
      fprintf(stderr, "width/height of the images must match!\n");
   } else {
   /* BODY: the "real" part! */
      for(x=0; x < im1->width; x++)
      {
         for(y=0; y < im1->width; y++)
         {
           totalDiff += fabs( GET_PIXEL(im1, x, y)[RED_C] - GET_PIXEL(im2, x, y)[RED_C] ) / 255.0;
           totalDiff += fabs( GET_PIXEL(im1, x, y)[GREEN_C] - GET_PIXEL(im2, x, y)[GREEN_C] ) / 255.0;
           totalDiff += fabs( GET_PIXEL(im1, x, y)[BLUE_C] - GET_PIXEL(im2, x, y)[BLUE_C] ) / 255.0;
         }
      }
      printf("%lf\n", 100.0 * totalDiff / (double)(im1->width * im1->height * 3) );
   /* BODY ends */
   }
   free_img(im1);
   free_img(im2);
}



image read_image(const char *name)
{
      FILE *pipe;
      char buf[MAXFULLCMDBUF];
      image im;
 
      FILE *test = fopen(name, "r");
      if ( test == NULL ) {
         fprintf(stderr, "cannot open file %s\n", name);
         return NULL;
      }
      fclose(test);
 
      snprintf(buf, MAXFULLCMDBUF, "convert \"%s\" ppm:-", name);
      pipe = popen(buf, "r");
      if ( pipe != NULL )
      {
           im = get_ppm(pipe);
           pclose(pipe);
           return im;
      }
      return NULL;
}


image get_ppm(FILE *pf)
{
        char buf[PPMREADBUFLEN], *t;
        image img;
        unsigned int w, h, d;
        int r;
 
        if (pf == NULL) return NULL;
        t = fgets(buf, PPMREADBUFLEN, pf);
        /* the code fails if the white space following "P6" is not '\n' */
        if ( (t == NULL) || ( strncmp(buf, "P6\n", 3) != 0 ) ) return NULL;
        do
        { /* Px formats can have # comments after first line */
           t = fgets(buf, PPMREADBUFLEN, pf);
           if ( t == NULL ) return NULL;
        } while ( strncmp(buf, "#", 1) == 0 );
        r = sscanf(buf, "%u %u", &w, &h);
        if ( r < 2 ) return NULL;
 
        r = fscanf(pf, "%u", &d);
        if ( (r < 1) || ( d != 255 ) ) return NULL;
        fseek(pf, 1, SEEK_CUR); /* skip one byte, should be whitespace */
 
        img = alloc_img(w, h);
        if ( img != NULL )
        {
            size_t rd = fread(img->buf, sizeof(pixel), w*h, pf);
            if ( rd < w*h )
            {
               free_img(img);
               return NULL;
            }
            return img;
        }
}
