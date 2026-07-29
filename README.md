# UAS Pemrograman - Sistem Manajemen Kebun Binatang

Demonstrasi 4 Pilar Object Oriented Programming (OOP) dalam C#

## 📋 Deskripsi

Program console C# yang mengimplementasikan 4 pilar OOP:
1. **Encapsulation** - Private fields dengan public properties dan validation
2. **Inheritance** - Dog, Cat, Bird mewarisi dari Animal
3. **Polymorphism** - Virtual method override, interface implementation, runtime polymorphism
4. **Abstraction** - Abstract class dan abstract method

## 🗂️ Struktur Project

```
ConsoleApp1/
├── Animal.cs          # Abstract base class
├── Dog.cs             # Derived class
├── Cat.cs             # Derived class
├── Bird.cs            # Derived class
├── IMoveable.cs       # Interface
├── ITrainable.cs      # Interface
├── Program.cs         # Main program
└── LAPORAN_UAS.md     # Laporan lengkap
```

## 🚀 Cara Menjalankan

1. Build project:
   ```bash
   msbuild ConsoleApp1/ConsoleApp1.csproj /p:Configuration=Debug
   ```

2. Run program:
   ```bash
   .\ConsoleApp1\bin\Debug\ConsoleApp1.exe
   ```

## 📝 Laporan

Lihat file [LAPORAN_UAS.md](LAPORAN_UAS.md) untuk penjelasan detail implementasi setiap pilar OOP.

## 🎓 Informasi Akademik

- **Mata Kuliah**: Pemrograman (2 SKS)
- **Semester**: Genap 2025/2026
- **Program Studi**: S1 Informatika

## 📄 License

MIT License - Educational Purpose
