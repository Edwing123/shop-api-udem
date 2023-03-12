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

        // Registros de productos.
        static List<Producto> Productos = new List<Producto>{
            // Productos Gucci.
            new Producto{Id = 1, Nombre = "Cartera Piel de Leon Gucci", Precio = 150, Categoria = "Accesorios", Id_Proveedor = 1 },
            new Producto{Id = 2, Nombre = "Camiseta blanca Gucci", Precio = 50, Categoria = "Ropa", Id_Proveedor = 1 },

            // Productos Adidas.
            new Producto{Id = 3, Nombre = "Zapatillas deportivas Adidas", Precio = 80, Categoria = "Calzado", Id_Proveedor = 2 },
            new Producto{Id = 4, Nombre = "Botines azules", Precio = 55, Categoria = "Calzado", Id_Proveedor = 2 },

            // Productos Nike.
            new Producto{Id = 5, Nombre = "Zapatos deportivos negros", Precio = 88, Categoria = "Calzado", Id_Proveedor = 3 },
            new Producto{Id = 6, Nombre = "Cancetines", Precio = 20, Categoria = "Ropa", Id_Proveedor = 3 },

            // Productos Apple.
            new Producto{Id = 7, Nombre = "IPhone 13", Precio = 1233, Categoria = "Tecnologia", Id_Proveedor = 4 },
            new Producto{Id = 8, Nombre = "MacBook Pro M1", Precio = 2200, Categoria = "Tecnologia", Id_Proveedor = 4 },
            new Producto{Id = 9, Nombre = "MacBook Pro M2", Precio = 2500, Categoria = "Tecnologia", Id_Proveedor = 4 },
            new Producto{Id = 10, Nombre = "Teclado Apple", Precio = 250, Categoria = "Tecnologia", Id_Proveedor = 4 },
            new Producto{Id = 11, Nombre = "AirPods", Precio = 210, Categoria = "Tecnologia", Id_Proveedor = 4 },

            // Productos de Sony.
            new Producto{Id = 12, Nombre = "PlayStation 5", Precio = 440, Categoria = "Tecnologia", Id_Proveedor = 5 },
            new Producto{Id = 13, Nombre = "PlayStation 4", Precio = 340, Categoria = "Tecnologia", Id_Proveedor = 5 },
            new Producto{Id = 14, Nombre = "Control inalambrico PlayStation 5", Precio = 70, Categoria = "Tecnologia", Id_Proveedor = 5 },
            new Producto{Id = 15, Nombre = "Control inalambrico PlayStation 4", Precio = 55, Categoria = "Tecnologia", Id_Proveedor = 5 },
        }

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
        }

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
        }
    }
}