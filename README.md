# 📘 Programa de Notas en C#

Este proyecto es una aplicación de consola en **C#** que simula diferentes módulos de gestión para entidades comunes como **estudiantes, bancos, tiendas, bibliotecas, restaurantes, estacionamientos, cines, mascotas, hoteles y clínicas**.
Cada módulo está implementado como una **clase independiente**, lo que facilita la organización, reutilización y el mantenimiento del código.

---

## 📂 Estructura del Proyecto

* **Program.cs**:
  Punto de entrada principal. Muestra un menú general para acceder a los distintos módulos y delega las acciones a cada clase.

* **Carpeta `Classes/`**:
  Contiene las clases correspondientes a cada módulo:

  * `Banks.cs` → Gestión de cuentas bancarias.
  * `Students.cs` → Registro y consulta de estudiantes (incluye funciones de notas, promedio, aprobados y en riesgo).
  * `Store.cs` → Inventario y venta de productos.
  * `Library.cs` → Registro y consulta de libros.
  * `Restaurant.cs` → Gestión de pedidos y cálculo de totales.
  * `Parking.cs` → Registro de entradas/salidas de vehículos y cálculo de pagos.
  * `Cine.cs` → Registro y consulta de películas.
  * `Pets.cs` → Registro y consulta de mascotas.
  * `Hotel.cs` → Reservas y cálculo de costos de estadía.
  * `Clinic.cs` → Registro de citas y cálculo de días restantes.

---

## 🧑‍💻 Enfoque en el Uso de Clases

El proyecto sigue un **enfoque modular orientado a objetos**:

* Cada módulo está encapsulado en una clase propia, siguiendo el principio de **responsabilidad única**.
* Cada clase contiene **listas internas** para manejar los registros temporalmente durante la ejecución.
* Los **métodos públicos** de cada clase permiten realizar operaciones específicas (ejemplo: agregar notas, registrar mascotas, calcular pagos).
* El archivo `Program.cs` actúa como **controlador principal**, instanciando las clases y gestionando el flujo de ejecución a través de un menú en consola.

Esto permite que el sistema sea **escalable**, de manera que agregar nuevos módulos solo requiere implementar una nueva clase y conectarla al menú.

---

## 🚀 Ejecución

1. Clona este repositorio o descarga el proyecto.
2. Ábrelo en cualquier editor compatible con C#.
3. Compila y ejecuta con:

   ```bash
   dotnet run
   ```


El programa mostrará un menú que te permitirá navegar entre los diferentes módulos y realizar operaciones específicas en cada uno.

---

## 📖 Ejemplo de Interacción

```
=== Menú Principal ===
1. Estudiantes
2. Banco
3. Tienda
4. Biblioteca
5. Restaurante
6. Estacionamiento
7. Cine
8. Mascotas
9. Hotel
10. Clínica
0. Salir
Seleccione una opción: 1

=== Módulo Estudiantes ===
Ingrese una nota: 4.5
Ingrese una nota: 2.8
Ingrese una nota: 1.7

Notas registradas: 4.5, 2.8, 1.7
Notas aprobadas: 4.5
Promedio del grupo: 3.0
⚠️ Hay estudiantes en riesgo académico
```

👨‍🏫 Proyecto desarrollado como práctica de **Programación Orientada a Objetos en C#**: uso de clases, listas, métodos, condicionales, ciclos y menú principal en consola.

---



