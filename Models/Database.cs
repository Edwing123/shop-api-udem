namespace Models {
    public class Database {
        // Registros de paises.
        static List<Pais> Paises = new List<Pais>{
            new Pais{ Id = 1, Nombre = "Nicaragua" },
            new Pais{ Id = 2, Nombre = "Costa Rica" },
            new Pais{ Id = 3, Nombre = "Panama" },
        };

        // Registros de proveedores.
        static List<Proveedor> Proveedores = new List<Proveedor>{
            new Proveedor{ Id = 1, Nombre = "Gucci" },
            new Proveedor{ Id = 2, Nombre = "Adidas" },
            new Proveedor{ Id = 3, Nombre = "Nike" },
            new Proveedor{ Id = 4, Nombre = "Apple" },
            new Proveedor{ Id = 5, Nombre = "Sony" },
        };

        // Registros de categorias.
        static List<Categoria> Categorias = new List<Id_Categoria>{
            new Categoria{ Id = 1, Nombre = "Accesorios" },
            new Categoria{ Id = 2, Nombre = "Ropa" },
            new Categoria{ Id = 3, Nombre = "Calzado" },
            new Categoria{ Id = 4, Nombre = "Tecnologia" },
        };

        // Registros de productos.
        static List<Producto> Productos = new List<Producto>{
            // Productos Gucci.
            new Producto{Id = 1, Nombre = "Cartera Piel de Leon Gucci", Precio = 150, Id_Categoria = 1, Id_Proveedor = 1 },
            new Producto{Id = 2, Nombre = "Camiseta blanca Gucci", Precio = 50, Id_Categoria = 2, Id_Proveedor = 1 },

            // Productos Adidas.
            new Producto{Id = 3, Nombre = "Zapatillas deportivas Adidas", Precio = 80, Id_Categoria = 3, Id_Proveedor = 2 },
            new Producto{Id = 4, Nombre = "Botines azules", Precio = 55, Id_Categoria = 3, Id_Proveedor = 2 },

            // Productos Nike.
            new Producto{Id = 5, Nombre = "Zapatos deportivos negros", Precio = 88, Id_Categoria = 3, Id_Proveedor = 3 },
            new Producto{Id = 6, Nombre = "Cancetines", Precio = 20, Id_Categoria = "Ropa", Id_Proveedor = 3 },

            // Productos Apple.
            new Producto{Id = 7, Nombre = "IPhone 13", Precio = 1233, Id_Categoria = 4, Id_Proveedor = 4 },
            new Producto{Id = 8, Nombre = "MacBook Pro M1", Precio = 2200, Id_Categoria = 4, Id_Proveedor = 4 },
            new Producto{Id = 9, Nombre = "MacBook Pro M2", Precio = 2500, Id_Categoria = 4, Id_Proveedor = 4 },
            new Producto{Id = 10, Nombre = "Teclado Apple", Precio = 250, Id_Categoria = 4, Id_Proveedor = 4 },
            new Producto{Id = 11, Nombre = "AirPods", Precio = 210, Id_Categoria = 4, Id_Proveedor = 4 },

            // Productos de Sony.
            new Producto{Id = 12, Nombre = "PlayStation 5", Precio = 440, Id_Categoria = 4, Id_Proveedor = 5 },
            new Producto{Id = 13, Nombre = "PlayStation 4", Precio = 340, Id_Categoria = 4, Id_Proveedor = 5 },
            new Producto{Id = 14, Nombre = "Control inalambrico PlayStation 5", Precio = 70, Id_Categoria = 4, Id_Proveedor = 5 },
            new Producto{Id = 15, Nombre = "Control inalambrico PlayStation 4", Precio = 55, Id_Categoria = 4, Id_Proveedor = 5 },
        };

        // Registros de usuarios.
        static List<Usuario> Usuarios = new List<Usuario>{
            // Usuarios de Nicaragua.
            new Usuario{ Id = 1, Nombres = "Edwin", Apellidos = "Garcia Valle", Id_Pais = 1 },
            new Usuario{ Id = 2, Nombres = "Yader", Apellidos = "Torrez", Id_Pais = 1 },

            // Usuarios de Costa Rica.
            new Usuario{ Id = 3, Nombres = "Joseph", Apellidos = "Zamorra", Id_Pais = 2 },

            // Usuarios de Panama.
            new Usuario{ Id = 4, Nombres = "Javier", Apellidos = "Garcia Urbina", Id_Pais = 3 },
            new Usuario{ Id = 5, Nombres = "Ivania", Apellidos = "Garcia Urbina", Id_Pais = 3 },
        };

        // Registros de compras.
        static List<Compra> Usuarios = new List<Compra>{
            // Ccompra #1.
            new Compra{ Id = 1,  Fecha = new DateTime("2022-10-12"), Id_Usuario = 1  },

            // Ccompra #2.
            new Compra{ Id = 2,  Fecha = new DateTime("2023-03-05"), Id_Usuario = 1  },

            // Ccompra #3.
            new Compra{ Id = 3,  Fecha = new DateTime("2023-02-23"), Id_Usuario = 2  },

            // Ccompra #4.
            new Compra{ Id = 4,  Fecha = new DateTime("2022-07-24"), Id_Usuario = 3  },

            // Ccompra #5.
            new Compra{ Id = 5,  Fecha = new DateTime("2022-10-13"), Id_Usuario = 3  },

            // Ccompra #6.
            new Compra{ Id = 6,  Fecha = new DateTime("2023-03-04"), Id_Usuario = 3  },

            // Ccompra #7.
            new Compra{ Id = 7,  Fecha = new DateTime("2023-02-18"), Id_Usuario = 4  },

            // Ccompra #8.
            new Compra{ Id = 8,  Fecha = new DateTime("2021-01-28"), Id_Usuario = 5  },
        };

        // Registros de los productos que pertencen a cada compra.
        static List<ProductoComprado> ProductosComprados = new List<ProductoComprado>{
            // Productos de la compra #1.
            new ProductoComprado{ Id = 1, Cantidad = 2, Id_Producto = 4, Id_Compra = 1 },
            new ProductoComprado{ Id = 2, Cantidad = 1, Id_Producto = 12, Id_Compra = 1 },
            new ProductoComprado{ Id = 3, Cantidad = 2, Id_Producto = 11, Id_Compra = 1 },

            // Productos de la compra #2.
            new ProductoComprado{ Id = 4, Cantidad = 8, Id_Producto = 6, Id_Compra = 2 },
            new ProductoComprado{ Id = 5, Cantidad = 4, Id_Producto = 7, Id_Compra = 2 },
            new ProductoComprado{ Id = 6, Cantidad = 1, Id_Producto = 10, Id_Compra = 2 },
            new ProductoComprado{ Id = 7, Cantidad = 2, Id_Producto = 9, Id_Compra = 2 },

            // Productos de la compra #3.
            new ProductoComprado{ Id = 8, Cantidad = 1, Id_Producto = 14, Id_Compra = 3 },
            new ProductoComprado{ Id = 9, Cantidad = 2, Id_Producto = 1, Id_Compra = 3 },

            // Productos de la compra #4.
            new ProductoComprado{ Id = 10, Cantidad = 1, Id_Producto = 8, Id_Compra = 4 },
            new ProductoComprado{ Id = 11, Cantidad = 1, Id_Producto = 11, Id_Compra = 4 },
            new ProductoComprado{ Id = 12, Cantidad = 1, Id_Producto = 10, Id_Compra = 4 },
            new ProductoComprado{ Id = 13, Cantidad = 2, Id_Producto = 5, Id_Compra = 4 },

            // Productos de la compra #5.
            new ProductoComprado{ Id = 14, Cantidad = 1, Id_Producto = 13, Id_Compra = 5 },
            new ProductoComprado{ Id = 15, Cantidad = 2, Id_Producto = 15, Id_Compra = 5 },
            new ProductoComprado{ Id = 16, Cantidad = 4, Id_Producto = 6, Id_Compra = 5 },

            // Productos de la compra #6.
            new ProductoComprado{ Id = 17, Cantidad = 1, Id_Producto = 9, Id_Compra = 6 },
            new ProductoComprado{ Id = 18, Cantidad = 2, Id_Producto = 2, Id_Compra = 6 },
            new ProductoComprado{ Id = 19, Cantidad = 3, Id_Producto = 3, Id_Compra = 6 },

            // Productos de la compra #7.
            new ProductoComprado{ Id = 20, Cantidad = 1, Id_Producto = 13, Id_Compra = 7 },
            new ProductoComprado{ Id = 21, Cantidad = 4, Id_Producto = 15, Id_Compra = 7 },
            new ProductoComprado{ Id = 22, Cantidad = 1, Id_Producto = 11, Id_Compra = 7 },
            new ProductoComprado{ Id = 23, Cantidad = 1, Id_Producto = 7, Id_Compra = 7 },
            new ProductoComprado{ Id = 24, Cantidad = 12, Id_Producto = 4, Id_Compra = 7 },

            // Productos de la compra #8.
            new ProductoComprado{ Id = 25, Cantidad = 4, Id_Producto = 3, Id_Compra = 8 },
            new ProductoComprado{ Id = 26, Cantidad = 6, Id_Producto = 5, Id_Compra = 8 },
            new ProductoComprado{ Id = 27, Cantidad = 20, Id_Producto = 6, Id_Compra = 8 },
        };
    }
}