# Proyecto final Ingenieria Web

## Descripción

La API propuesta sera la de una tienda de productos en linea, en donde
los usuarios podran comprar productos de diferentes categorias.

## Modelo de datos

Las entidades seran:

- Usuario.
- Proveedor.
- Categoria.
- Producto.
- Compra.
- Pais.

### Usuario

Un usuario cuenta con los siguientes atributos:

- Id.
- Nombres.
- Apellidos.

### Proveedor

Un proveedor cuenta con los siguientes atributos:

- Id.
- Nombre.

### Categoria

Una categoria cuenta con los siguientes atributos:

- Id.
- Nombre.

### Producto

Un producto cuenta con los siguientes atributos:

- Id.
- Nombre.
- Precio.
- Categoria.


### Compra

Una compra cuenta con los siguientes atributos:

- Id.
- Fecha.

### Pais

Una pais cuenta con los siguientes atributos:

- Id.
- Nombre.

## Relaciones de las entidades

### Un usuario realiza muchas compras - una compra es realizada por un usuario

La cardinalidad de esta relacion es 1:M, en donde un usuario realiza muchas
compras, y una compra es realizada por un usuario. La llave forranea ira a la
entidad cuya parte de la cardinalidad sea "M", en este caso, esta entidad es la entidad compra.

Habiendo dicho esto, el modelo relacional de la entidad Compra sera el siguiente:

Compra(Id, Fecha, Id_Usuario)

### Un usuario pertenece a un pais - un pais tiene a muchos usuarios

La cardinalidad de esta relacion es M:1, en donde un usuario pertece a un pais, y un pais tiene muchos usuarios. La llave forranea ira la entidad cuya parte de la cardinalidad sea "M", en este, esta es la entidad usuario.

Habiendo dicho esto, el modelo relacional de la entidad Usuario sera el siguiente:

Usuario(Id, Nombres, Apellidos, Id_Pais)

### Un proveedor provee muchos productos - un producto es proveido por un proveedor

La cardinalidad es 1:M, en donde un producto es proveido por un proveedor, y un proveedor provee muchos productos. La llave forranea ira a la entidad cuya parte de la cardinalidad sea "M", en este caso, esta entidad es un producto.

Habiendo dicho esto, el modelo relacional de la entidad Producto sera el siguiente:

Producto(Id, Nombre, Precio, Categoria, Id_Proveedor)

### Un producto pertenece a una categoria - una categoria es usada por muchos productos

La cardinalidad es M:1, en donde un producto tiene una solo categoria, pero una categoria la pueden tener muchos productos. La llave forranea ira a la entidad en donde la relacion sea M, en este caso, esta entidad es un producto.

Habiendo dicho esto, el modelo relacional de la entidad Producto sera el siguiente:

Producto(Id, Nombre, Precio, Categoria, Id_Categoria)

### Una compra tiene muchos producto - un producto pertence a muchas compras

La cardinalidad es M:N, en donde una compra esta compuesta de muchos productos, y un producto puede pertenecer a muchas compras. Al ser una relacion muchos-a-muchos, se tendra que crear una tabla extra, dentro de esa table se hara la referencia de las llaves primarias de las entidades que componen esta relacion, en este caso, estas en serian Producto y Compra.

Habiendo dicho esto, el modelo relacional de esta nueva entidad sera el siguiente:

Producto_Comprado(Id, Cantidad, Id_Compra, Id_Producto)