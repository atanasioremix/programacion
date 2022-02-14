El poryecto básicamente trata de un shotter donde puedes destruir bolas o esquivarlas.

Los patrones de diseño que se utiliza son los siguientes:

Object Pool: este patrón se ha utilizado para controlar el número de las balas y los enemigos que aparacén al ser invocados, de manera que no aparecera infinitos objetos por lo que así se permite no tener un bajón importante de fps

Singleton: permite restringir la creación de objetos pertenecientes a una clase o el valor de un tipo a un único objeto

Prototype: el patrón a sido utilizado para crear los prefabs bala y enemigo de manera que no tenga porque estar en la propia escena si no que es invocado por otros medios

he añadido también unas mecánicas extra como:

temporizador: de manera que cuando el temporizador llege a 0 gane el jugador

colisionador: sirve para que el enemigo colisiona con el jugador te ofrezca un gameover

Toda la información que necesita saber esta documentado en cada script

 
