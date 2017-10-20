#!/usr/bin/perl
 use warnings;
 use strict;
 use Imager::File::JPEG;

for( $a=0; $a < 10000; $a = $a + 1) {

 my $img=Imager->new();                         # create empty image
  $img->read(file=>'../Lenna50.jpg',type=>'jpeg') or # read image from file
     die $img->errstr();  
 my $img2=Imager->new();                         # create empty image
  $img2->read(file=>'../Lenna100.jpg',type=>'jpeg') or # read image from file
     die $img2->errstr();  

my $diff = $img->difference(other=>$img2);
}
