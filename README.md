# Trabajo-Practico-1
Trabajo practico 1:
Para poder implementar el boton delete en mi proyecto mvc declare mi
accion Delete en el Peli controller que tiene como parametro el code.
Una vez que elimine la pelicula le decimos que redireccione a la accion de index.
Luego en el detail.cshtml que es mi vista creada para que nos muestre, cree el boton delete 
con asp-route-code = @Model.Code para mandarle el parametro del Get() creado y con una accion de asp de tipo "delete".
