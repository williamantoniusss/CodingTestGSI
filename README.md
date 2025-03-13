1. ConvertTextToNumbers(string text)
Mengubah setiap karakter dalam teks menjadi angka berdasarkan kamus khusus (charToNumberMap).
Karakter yang tidak ada dalam kamus akan diabaikan.
Hasil akhirnya adalah list angka yang sesuai dengan teks yang diberikan.

2. CalculateAlternatingSum(List<int> numbers, out int finalResult)
Menghitung hasil dengan penjumlahan dan pengurangan bergantian dari daftar angka.
Jika index ganjil → ditambah, jika index genap → dikurangi.
Menghasilkan string proses perhitungan dan nilai absolut dari hasil akhir.

3. GenerateIncrementalSeriesWithLetters(int target)
Menghasilkan urutan huruf berdasarkan angka target menggunakan aturan penjumlahan bertahap.
Huruf pertama ditentukan dari penjumlahan angka berurutan (0, 1, 2, 3, ...).
Jika belum mencapai target, ditambahkan "A B" untuk melengkapi nilai yang kurang.

4. ConvertFinalOutput(string step3Result)
Memodifikasi hasil Step 3 berdasarkan aturan tertentu:
Jika huruf terakhir adalah "B", ubah huruf sebelumnya menjadi "B" dan huruf terakhir menjadi "E".
Jika bukan "B", cukup ubah huruf terakhir menjadi "E".
Output berupa string urutan huruf yang telah dimodifikasi.

5. ConvertToFinalNumbers(string step4Output)
Mengubah hasil Step 4 (urutan huruf) kembali menjadi angka menggunakan kamus khusus.
Huruf yang tidak ada dalam kamus akan diabaikan.
Hasil akhirnya adalah list angka yang sesuai dengan urutan huruf hasil Step 4.
