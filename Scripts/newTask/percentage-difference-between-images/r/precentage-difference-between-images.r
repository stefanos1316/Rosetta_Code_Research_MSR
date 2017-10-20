require(jpeg)

for ( i in 0:10000 ) {
	img1<-readJPEG("../Lenna50.jpg")
	img2<-readJPEG("../Lenna100.jpg")
	if(length(img1)==length(img2)){   # check same pixel number
  	paste(100*sum(img1==img2)/length(img1),"%")
	}
}
