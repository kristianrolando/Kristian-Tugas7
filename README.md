# Kristian-Tugas7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)


Yang perlu dioptimalkan.
* Sprite-sprite yang terpisah-pisah, cara optimaze : sprite atlas
* cara load data yang tidak dibutuhkan (contoh : kasus audio yang load 4 audio, padahal cuman pakai 1)
* spawn object yang terus terusan create new object, cara fix : object pooling
* draw call yang kuran optimaze, object dengan material yg sama akan lebih baik di merge dengan metode static batching


![compare_audio](https://user-images.githubusercontent.com/101899403/187155671-329cd857-09bb-41bd-8ab6-a0173ee78df7.png)
dengan mengganti algoritma sebelumnya, menjadi memakai resources.load. Kemudian dicari berdasarkan namanya untuk diload. hal ini mengatasi permasalahan audio clip yang ikut diload saat hanya satu yang dimainkan, selain itu. Saat diplay tanpa audio, audio juga tidak terload.
![compare_statistics](https://user-images.githubusercontent.com/101899403/187155677-19703872-6055-4c98-a434-c531d9966cc8.png)
dengan melakukan statis bratching dan object pooling, membuat FPS meningkat dratis dan batches menurun.
