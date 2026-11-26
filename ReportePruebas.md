# Reporte de Pruebas - Arbol Binario de Busqueda (ABB)

## Objetivo
Verificar el correcto funcionamiento de la implementacion mediante memoria dinamica del Arbol Binario de Busqueda (`NodoABB` y `ArbolBinarioBusqueda`), incluyendo insercion, busqueda, eliminacion en sus tres casos y la integridad de los recorridos en profundidad (Preorden, Inorden y Postorden).

## Casos de Prueba Ejecutados

Conjunto de datos base insertado: `50, 30, 70, 20, 40, 60, 80`.

| Caso de prueba | Operacion evaluada | Resultado esperado | Resultado obtenido | Estado |
| :--- | :--- | :--- | :--- | :--- |
| 1 | Arbol vacio inicial | Cantidad = 0, recorridos vacios | Cantidad = 0, recorridos vacios | APROBADA |
| 2 | Insercion y rechazo de duplicados | Cantidad = 7, `Insertar(50)` = false | Cantidad = 7, `duplicado(50) rechazado = True` | APROBADA |
| 3 | Recorrido Preorden | `50, 30, 20, 40, 70, 60, 80` | `50, 30, 20, 40, 70, 60, 80` | APROBADA |
| 4 | Recorrido Inorden | `20, 30, 40, 50, 60, 70, 80` | `20, 30, 40, 50, 60, 70, 80` | APROBADA |
| 5 | Recorrido Postorden | `20, 40, 30, 60, 80, 70, 50` | `20, 40, 30, 60, 80, 70, 50` | APROBADA |
| 6 | Busqueda de nodos | `Buscar(60)` = true, `Buscar(99)` = false | `Buscar(60) = True, Buscar(99) = False` | APROBADA |
| 7 | Eliminacion de nodo hoja (`20`) | Inorden: `30, 40, 50, 60, 70, 80` | Inorden: `30, 40, 50, 60, 70, 80` | APROBADA |
| 8 | Eliminacion de nodo con un hijo (`30`) | Inorden: `40, 50, 60, 70, 80`, Preorden: `50, 40, 70, 60, 80` | Inorden: `40, 50, 60, 70, 80`, Preorden: `50, 40, 70, 60, 80` | APROBADA |
| 9 | Eliminacion de raiz con dos hijos (`50`) | Inorden: `40, 60, 70, 80`, Preorden: `60, 40, 70, 80`, Postorden: `40, 80, 70, 60` | Inorden: `40, 60, 70, 80`, Preorden: `60, 40, 70, 80`, Postorden: `40, 80, 70, 60` | APROBADA |
| 10 | Eliminacion de nodo inexistente (`999`) | `Eliminar(999)` = false, Cantidad = 4 | Resultado = True, Cantidad = 4 | APROBADA |

## Salida Directa de Ejecucion (`--test`)

```text
[APROBADA] Arbol vacio inicial: Cantidad = 0, recorridos vacios
[APROBADA] Insercion y rechazo de duplicados: Cantidad = 7, duplicado(50) rechazado = True
[APROBADA] Recorrido Preorden: Obtenido: [50, 30, 20, 40, 70, 60, 80]
[APROBADA] Recorrido Inorden (orden ascendente): Obtenido: [20, 30, 40, 50, 60, 70, 80]
[APROBADA] Recorrido Postorden: Obtenido: [20, 40, 30, 60, 80, 70, 50]
[APROBADA] Busqueda de nodos: Buscar(60) = True, Buscar(99) = False
[APROBADA] Eliminacion de nodo hoja (20): Inorden: [30, 40, 50, 60, 70, 80]
[APROBADA] Eliminacion de nodo con un hijo (30): Inorden: [40, 50, 60, 70, 80] | Preorden: [50, 40, 70, 60, 80]
[APROBADA] Eliminacion de raiz con dos hijos (50): Inorden: [40, 60, 70, 80] | Preorden: [60, 40, 70, 80] | Postorden: [40, 80, 70, 60]
[APROBADA] Eliminacion de nodo inexistente (999): Resultado = True, Cantidad = 4

Resumen: 10/10 pruebas aprobadas.
```

## Conclusion
Los recorridos Preorden, Inorden y Postorden mantienen la integridad estructural del ABB tras inserciones, busquedas y eliminaciones en nodos hoja, nodos con un hijo y nodos con dos hijos (reemplazo por sucesor inorden).
