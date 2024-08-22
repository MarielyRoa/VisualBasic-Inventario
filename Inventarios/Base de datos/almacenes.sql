USE Almacen;

CREATE TABLE Productos (
    ID_Producto INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Precio DECIMAL(10, 2) NOT NULL,
    Cantidad INT NOT NULL
);
CREATE TABLE Proveedores (
    ID_Proveedor INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Contacto VARCHAR(100),
    Telefono VARCHAR(20)
);
CREATE TABLE EntradasInventario (
    ID_Entrada INT PRIMARY KEY IDENTITY,
    Fecha DATE NOT NULL,
    ID_Producto INT,
    Cantidad INT,
    ID_Proveedor INT,
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor)
);
CREATE TABLE SalidasInventario (
    ID_Salida INT PRIMARY KEY IDENTITY,
    Fecha DATE NOT NULL,
    ID_Producto INT,
    Cantidad INT,
    Destino VARCHAR(100),
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);