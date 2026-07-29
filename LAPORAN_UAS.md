# LAPORAN UJIAN AKHIR SEMESTER (UAS)
## PEMROGRAMAN - DEMONSTRASI 4 PILAR OOP

---

### INFORMASI MAHASISWA
- **Nama**: [Isi Nama Anda]
- **NIM**: [Isi NIM Anda]
- **Program Studi**: S1 Informatika
- **Mata Kuliah**: Pemrograman (2 SKS)
- **Semester**: Genap 2025/2026
- **Dosen Pengampu**: 
  - Kamarudin, M.Kom
  - Novi Prisma Yunita, M.Kom

---

## DAFTAR ISI

1. [Abstraction & Encapsulation - Animal.cs](#1-abstraction--encapsulation---animalcs)
2. [Inheritance - Dog.cs, Cat.cs, Bird.cs](#2-inheritance---dogcs-catcs-birdcs)
3. [Polymorphism (Interface) - IMoveable.cs, ITrainable.cs](#3-polymorphism-interface---imoveablecs-itrainablecs)
4. [Polymorphism (Runtime) - Program.cs](#4-polymorphism-runtime---programcs)
5. [Screenshot Output Program](#5-screenshot-output-program)

---

## 1. ABSTRACTION & ENCAPSULATION - Animal.cs

### 📋 Konsep yang Didemonstrasikan
File `Animal.cs` mendemonstrasikan dua pilar OOP sekaligus:
1. **Abstraction** - Menggunakan abstract class dan abstract method
2. **Encapsulation** - Menggunakan private fields dengan public properties

### 📝 Penjelasan Kode

#### 1.1 Abstract Class Declaration
```csharp
public abstract class Animal
```
- Keyword `abstract` membuat class ini tidak bisa diinstansiasi langsung
- Harus diwariskan ke child class terlebih dahulu (Dog, Cat, Bird)
- Abstract class boleh punya method dengan implementasi DAN method tanpa implementasi

#### 1.2 Encapsulation - Private Fields
```csharp
private string nama;
private int umur;
private string habitat;
```
- Keyword `private` menyembunyikan data dari akses langsung luar class
- Data hanya bisa diakses melalui public properties
- Ini adalah **data hiding** - prinsip utama encapsulation

#### 1.3 Encapsulation - Public Properties dengan Validation
```csharp
public int Umur 
{ 
    get { return umur; }
    set 
    { 
        if (value >= 0)
            umur = value;
        else
            Console.WriteLine("Error: Umur tidak boleh negatif!");
    }
}
```
- Properties memberikan kontrol akses ke private fields
- `get` accessor untuk membaca nilai
- `set` accessor untuk mengubah nilai
- **Validation**: Umur tidak boleh negatif - ini keuntungan encapsulation!
- Tanpa encapsulation, kita tidak bisa validasi input

#### 1.4 Constructor dengan Encapsulation
```csharp
public Animal(string nama, int umur, string habitat)
{
    this.Nama = nama;
    this.Umur = umur;
    this.Habitat = habitat;
}
```
- Constructor menggunakan properties (bukan langsung ke private fields)
- Validation otomatis terpanggil saat object dibuat

#### 1.5 Abstraction - Abstract Method
```csharp
public abstract void Makan();
```
- **Abstract method** = method tanpa implementasi (tidak ada body `{}`)
- Setiap child class **WAJIB** mengimplementasi method ini
- Setiap hewan makan dengan cara berbeda, jadi implementasinya diserahkan ke child

#### 1.6 Polymorphism - Virtual Method
```csharp
public virtual void Bersuara()
{
    Console.WriteLine("Hewan ini mengeluarkan suara...");
}
```
- **Virtual method** = method dengan implementasi yang BISA di-override
- Berbeda dengan abstract (wajib), virtual bersifat opsional
- Child class bisa override atau pakai implementasi default ini

#### 1.7 Regular Method (Code Reuse)
```csharp
public void TampilkanInfo()
{
    Console.WriteLine($"Nama: {Nama}");
    Console.WriteLine($"Umur: {Umur} tahun");
    Console.WriteLine($"Habitat: {Habitat}");
}
```
- **Regular method** = method biasa dengan implementasi
- Semua child class bisa pakai method ini langsung tanpa override
- Ini adalah **code reuse** - tulis sekali, pakai berkali-kali

### ✅ Kesimpulan Animal.cs
- **Abstraction**: Class abstract dengan abstract method `Makan()`
- **Encapsulation**: Private fields (`nama`, `umur`, `habitat`) + public properties dengan validation
- **Polymorphism**: Virtual method `Bersuara()` yang bisa di-override
- **Code Reuse**: Regular method `TampilkanInfo()` yang bisa dipakai semua child

---

## 2. INHERITANCE - Dog.cs, Cat.cs, Bird.cs

### 📋 Konsep yang Didemonstrasikan
Ketiga file ini mendemonstrasikan:
1. **Inheritance** - Pewarisan dari class Animal
2. **Polymorphism** - Override method parent + implementasi interface

### 📝 Penjelasan Dog.cs

#### 2.1 Inheritance Declaration
```csharp
public class Dog : Animal, IMoveable, ITrainable
```
- `:` Animal = Dog **mewarisi** dari Animal (inheritance)
- Dog mendapat semua properties dan methods dari Animal
- `, IMoveable, ITrainable` = Dog juga implementasi 2 interface (polymorphism)

#### 2.2 Encapsulation di Child Class
```csharp
private string ras;
private List<string> daftarTrik;

public string Ras 
{ 
    get { return ras; }
    set { ras = value; }
}
```
- Child class juga bisa punya private fields sendiri
- `ras` adalah property khusus Dog (tidak ada di Animal)
- Encapsulation tetap diterapkan di child class

#### 2.3 Constructor dengan Inheritance
```csharp
public Dog(string nama, int umur, string habitat, string ras) 
    : base(nama, umur, habitat)
{
    this.Ras = ras;
    this.daftarTrik = new List<string>();
}
```
- `: base(nama, umur, habitat)` = memanggil constructor parent (Animal)
- Ini adalah **constructor chaining**
- Parameter parent diteruskan ke constructor Animal
- Parameter khusus Dog (`ras`) diinisialisasi di body constructor

#### 2.4 Polymorphism - Override Abstract Method
```csharp
public override void Makan()
{
    Console.WriteLine($"{Nama} (Anjing) sedang makan daging dan dog food");
}
```
- Keyword `override` untuk mengimplementasi abstract method dari parent
- Ini **WAJIB** dilakukan karena `Makan()` abstract di Animal
- Implementasi berbeda untuk setiap hewan (polymorphism)

#### 2.5 Polymorphism - Override Virtual Method
```csharp
public override void Bersuara()
{
    Console.WriteLine($"{Nama}: Guk guk guk! Woof woof!");
}
```
- Override virtual method dari parent
- Mengganti implementasi default dengan implementasi spesifik Dog
- Setiap hewan bersuara berbeda (polymorphism)

#### 2.6 Polymorphism - Interface Implementation
```csharp
public void Berjalan()
{
    Console.WriteLine($"{Nama} berjalan dengan 4 kaki");
}

public void Berlari()
{
    Console.WriteLine($"{Nama} berlari dengan cepat mengejar bola");
}
```
- Implementasi method dari interface `IMoveable`
- Interface mendefinisikan kontrak, class mengimplementasi detail
- Setiap hewan bergerak dengan cara berbeda (polymorphism)

#### 2.7 Interface ITrainable Implementation
```csharp
public void Berlatih(string trik)
{
    daftarTrik.Add(trik);
    Console.WriteLine($"{Nama} sedang berlatih trik baru: {trik}");
}
```
- Implementasi method dari interface `ITrainable`
- Hanya Dog yang bisa dilatih (Cat dan Bird tidak implementasi ITrainable)
- Ini menunjukkan fleksibilitas interface

### 📝 Penjelasan Cat.cs

#### 2.8 Cat Inheritance
```csharp
public class Cat : Animal, IMoveable
```
- Cat juga mewarisi dari Animal
- Cat hanya implementasi `IMoveable`, tidak `ITrainable`
- Setiap class bisa implementasi interface yang berbeda

#### 2.9 Cat Properties
```csharp
private bool apakahLiar;
private string warnaKulit;
```
- Cat punya property khusus sendiri
- Berbeda dengan Dog yang punya `ras`
- Setiap child class bisa punya property unik


#### 2.10 Cat Override Methods
```csharp
public override void Makan()
{
    Console.WriteLine($"{Nama} (Kucing) sedang makan ikan dan whiskas");
}

public override void Bersuara()
{
    Console.WriteLine($"{Nama}: Meong meong! Miauw!");
}
```
- Cat override method Makan() dan Bersuara() dengan implementasi berbeda
- Hasilnya berbeda dari Dog - ini polymorphism!

### 📝 Penjelasan Bird.cs

#### 2.11 Bird Inheritance
```csharp
public class Bird : Animal, IMoveable
```
- Bird juga mewarisi dari Animal (sama seperti Dog dan Cat)
- Bird hanya implementasi `IMoveable`, tidak `ITrainable`
- Bird tidak bisa dilatih seperti Dog

#### 2.12 Bird Properties
```csharp
private double rentangSayap;
private bool bisaTerbang;

public double RentangSayap { get; set; }
public bool BisaTerbang { get; set; }
```
- Bird punya property khusus: `rentangSayap` dan `bisaTerbang`
- Berbeda dengan Dog (`ras`) dan Cat (`warnaKulit`)
- Property menggunakan tipe `double` dan `bool`

#### 2.13 Bird Override Methods
```csharp
public override void Makan()
{
    Console.WriteLine($"{Nama} (Burung) sedang makan biji-bijian dan serangga");
}

public override void Bersuara()
{
    Console.WriteLine($"{Nama}: Cuit cuit cuit! Kicau kicau!");
}
```
- Bird override method `Makan()` dan `Bersuara()` dengan implementasi berbeda
- Burung makan biji-bijian (berbeda dari Dog yang makan daging)
- Burung bersuara "Cuit cuit" (berbeda dari Dog "Guk guk" dan Cat "Meong")
- Ini adalah **polymorphism** - method sama, hasil beda!

#### 2.14 Bird dengan Validation
```csharp
public double RentangSayap 
{ 
    set 
    { 
        if (value > 0)
            rentangSayap = value;
        else
            Console.WriteLine("Error: Rentang sayap harus positif!");
    }
}
```
- Bird punya **encapsulation dengan validation** (seperti Animal.Umur)
- Rentang sayap harus positif (tidak boleh negatif atau nol)
- Setiap class bisa punya validation rule sendiri

### ✅ Kesimpulan Inheritance
- **Dog, Cat, Bird** mewarisi dari Animal (inheritance)
- Semua bisa pakai TampilkanInfo() dari parent (code reuse)
- Semua override Makan() dan Bersuara() dengan implementasi berbeda (polymorphism)
- Setiap class punya property unik (as, warnaKulit, entangSayap)

---

## 3. POLYMORPHISM (Interface) - IMoveable.cs, ITrainable.cs

### 📋 Konsep yang Didemonstrasikan
- **Polymorphism** melalui interface
- **Multiple interface implementation**

### 📝 Penjelasan IMoveable.cs

```csharp
public interface IMoveable
{
    void Berjalan();
    void Berlari();
}
```

#### 3.1 Interface Declaration
- Keyword interface mendefinisikan kontrak/aturan
- Interface HANYA berisi signature method (tanpa implementasi)
- Semua method di interface otomatis public dan bstract

#### 3.2 Implementasi oleh Class
- Dog, Cat, Bird semua implementasi IMoveable
- Masing-masing punya implementasi berbeda
- Dog: berjalan dengan 4 kaki
- Cat: berjalan dengan anggun
- Bird: berjalan dengan melompat-lompat

### 📝 Penjelasan ITrainable.cs

```csharp
public interface ITrainable
{
    void Berlatih(string trik);
    void TampilkanTrik();
}
```

#### 3.3 Selective Implementation
- Hanya Dog yang implementasi ITrainable
- Cat dan Bird tidak bisa dilatih (tidak implementasi interface ini)
- Ini menunjukkan fleksibilitas interface - tidak semua class harus implementasi semua interface

### ✅ Kesimpulan Interface
- Interface mendefinisikan "apa yang bisa dilakukan" tanpa menentukan "bagaimana"
- Berbeda dengan inheritance yang bersifat "is-a", interface bersifat "can-do"
- Satu class bisa implementasi multiple interface

---

## 4. POLYMORPHISM (Runtime) - Program.cs

### 📋 Konsep yang Didemonstrasikan
- **Runtime Polymorphism** dengan List
- **Type casting**
- **Polymorphic behavior**

### 📝 Penjelasan Kode

#### 4.1 List dengan New Object
```csharp
List<Animal> daftarHewan = new List<Animal>
{
    new Dog("Buddy", 5, "Kandang Anjing", "Golden Retriever"),
    new Cat("Whiskers", 3, "Kandang Kucing", false, "Putih"),
    new Bird("Tweety", 2, "Kandang Burung", 25.5, true)
};
```
- List<Animal> bisa menyimpan Dog, Cat, Bird (karena mereka semua turunan Animal)
- 
ew Dog(...) langsung di dalam List - modern C# syntax
- Ini adalah **polymorphism** - tipe parent bisa menyimpan tipe child

#### 4.2 Foreach Loop Polymorphic
```csharp
foreach (Animal hewan in daftarHewan)
{
    hewan.TampilkanInfo();
    hewan.Bersuara();
    hewan.Makan();
    Console.WriteLine();
}
```
- Loop melalui List<Animal>
- Variabel hewan bertipe Animal, tapi isinya bisa Dog/Cat/Bird
- Method yang dipanggil (Bersuara(), Makan()) otomatis memanggil versi yang tepat
- Dog.Bersuara() → "Guk guk guk!"
- Cat.Bersuara() → "Meong meong!"
- Bird.Bersuara() → "Cuit cuit cuit!"
- Ini adalah **runtime polymorphism** - method yang dipanggil ditentukan saat program berjalan

#### 4.3 Keuntungan Runtime Polymorphism
- Satu loop bisa handle berbagai tipe object
- Tidak perlu if-else atau switch untuk cek tipe
- Mudah menambah hewan baru tanpa ubah loop
- Code lebih clean dan maintainable

### ✅ Kesimpulan Program.cs
- Demonstrasi **runtime polymorphism** dengan List<Animal>
- Satu tipe parent bisa menyimpan berbagai tipe child
- Method yang tepat dipanggil otomatis sesuai tipe object sebenarnya

---

## 5. SCREENSHOT OUTPUT PROGRAM

### 📸 Cara Menjalankan Program
1. Buka folder: D:\1.Main Folder\3.Ujian\UAS SEMESTER 2\PEMROGRAMAN
2. Double-click file: ConsoleApp1\bin\Debug\ConsoleApp1.exe
3. Screenshot output console

### 📋 Output yang Diharapkan

Program akan menampilkan output untuk 3 hewan (Buddy, Whiskers, Tweety):

**Untuk setiap hewan:**
- Nama, Umur, Habitat (dari TampilkanInfo())
- Suara hewan (dari Bersuara())
- Cara makan (dari Makan())

**Contoh output:**
\\\
Nama: Buddy
Umur: 5 tahun
Habitat: Kandang Anjing
Buddy: Guk guk guk! Woof woof!
Buddy (Anjing) sedang makan daging dan dog food

Nama: Whiskers
Umur: 3 tahun
Habitat: Kandang Kucing
Whiskers: Meong meong! Miauw!
Whiskers (Kucing) sedang makan ikan dan whiskas

Nama: Tweety
Umur: 2 tahun
Habitat: Kandang Burung
Tweety: Cuit cuit cuit! Kicau kicau!
Tweety (Burung) sedang makan biji-bijian dan serangga
\\\

### 📝 Penjelasan Output
- **3 hewan berbeda** tapi dipanggil dengan cara yang **sama** (polymorphism)
- **Hasil berbeda** untuk setiap hewan (Bersuara dan Makan berbeda)
- **Satu loop** bisa handle semua tipe hewan (runtime polymorphism)

---

## KESIMPULAN

Program ini berhasil mendemonstrasikan **4 Pilar OOP**:

1. ✅ **Encapsulation (20 poin)**
   - Private fields: 
ama, umur, habitat, as, warnaKulit, entangSayap
   - Public properties dengan validation
   - Data hiding dari akses langsung

2. ✅ **Inheritance (20 poin)**
   - Dog, Cat, Bird mewarisi dari Animal
   - Constructor chaining dengan ase()
   - Code reuse dengan method parent

3. ✅ **Polymorphism (40 poin)**
   - Virtual method override (Bersuara())
   - Abstract method implementation (Makan())
   - Interface implementation (IMoveable, ITrainable)
   - Runtime polymorphism dengan List<Animal>

4. ✅ **Abstraction (20 poin)**
   - Abstract class Animal
   - Abstract method Makan()
   - Menyembunyikan detail implementasi

---

**TOTAL: 100 POIN**

