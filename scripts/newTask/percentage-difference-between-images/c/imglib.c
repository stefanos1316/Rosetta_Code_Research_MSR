#include <stdlib.h>
#include <stdio.h>
#include "imglib.h"

#define PPMREADBUFLEN 256

typedef unsigned char luminance;
typedef luminance pixel1[1];
typedef struct {
   unsigned int width;
   unsigned int height;
   luminance *buf;
} grayimage_t;
typedef grayimage_t *grayimage;
 
grayimage alloc_grayimg(unsigned int, unsigned int);
grayimage tograyscale(image);
image tocolor(grayimage);


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
 
void output_ppm(FILE *fd, image img)
{
  unsigned int n;
  (void) fprintf(fd, "P6\n%d %d\n255\n", img->width, img->height);
  n = img->width * img->height;
  (void) fwrite(img->buf, sizeof(pixel), n, fd);
  (void) fflush(fd);
}

image tocolor(grayimage img)
{
   unsigned int x, y;
   image timg;
   luminance l;
   unsigned int ofs;
 
   timg = alloc_img(img->width, img->height);
 
   for(x=0; x < img->width; x++)
   {
      for(y=0; y < img->height; y++)
      {
        ofs = (y * img->width) + x;
        l = img->buf[ofs][0];
        timg->buf[ofs][0] = l;
        timg->buf[ofs][1] = l;
        timg->buf[ofs][2] = l;
      }
   }
   return timg;
}

grayimage tograyscale(image img)
{
   unsigned int x, y;
   grayimage timg;
   double rc, gc, bc, l;
   unsigned int ofs;
 
   timg = alloc_grayimg(img->width, img->height);
 
   for(x=0; x < img->width; x++)
   {
      for(y=0; y < img->height; y++)
      {
        ofs = (y * img->width) + x;
        rc = (double) img->buf[ofs][0];
        gc = (double) img->buf[ofs][1];
        bc = (double) img->buf[ofs][2];
        l = 0.2126*rc + 0.7152*gc + 0.0722*bc;
        timg->buf[ofs][0] = (luminance) (l+0.5);
      }
   }
   return timg;
}

grayimage alloc_grayimg(unsigned int width, unsigned int height)
{
     grayimage img;
     img = malloc(sizeof(grayimage_t));
     img->buf = malloc(width*height*sizeof(pixel1));
     img->width = width;
     img->height = height;
     return img;
}
