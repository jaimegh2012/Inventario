# Inventario

La base de datos se creo por medio de DbContext, La biblioteca de Clases Inventario.BL es la que contiene todo lo relacionado con la base datos.
La clase contexto es la que nos sirve de enlace con la base de datos, dicha clase crea la BD, cuando no existe la BD indicamos en dicha clase, también la BD se guarda
en el escritorio de nuestra computadora solo para efectos de prueba durante el desarrolo.
Para cada tabla se genera una clase que lleva sus propiedades y otra claseBL que lleva todo lo relacionado al CRUD para dicha tabla.


Dentro del controlador Productos, se encuentra la accion para leer registros (Index), para crear registros(Crear), para editar (Editar), para eliminar(Eliminar). 
Dentro de cada Accion, se llama a las respectivas funciones para realizar la tarea necesaria(crear, actualizar, eliminar, leer) y esto se logra por medio de una instancia que se crea de la clase ProductosBL que contiene todas las funciones.




