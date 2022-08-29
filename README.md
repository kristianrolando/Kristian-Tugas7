# Kristian-Tugas7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)


Yang perlu dioptimalkan.
* Sprite-sprite yang terpisah-pisah, cara optimaze : sprite atlas
* cara load data yang tidak dibutuhkan (contoh : kasus audio yang load 4 audio, padahal cuman pakai 1)
* spawn object yang terus terusan create new object, cara fix : object pooling
* draw call yang kuran optimaze, object dengan material yg sama akan lebih baik di merge dengan metode static batching

![Gambar teks editor VS Code]([https://www.petanikode.com/img/markdown/markdown-vscode.png](https://github.com/kristianrolando/Kristian-Tugas7/tree/main/Screenshoot/Compare/compare_audio.png))

![Gambar teks editor VS Code]([https://www.petanikode.com/img/markdown/markdown-vscode.png](https://github.com/kristianrolando/Kristian-Tugas7/tree/main/Screenshoot/Compare/compare_statistics.png))
