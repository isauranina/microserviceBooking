# Reglas para Test de Contratos (Pacts) - React Client

Este documento define el set de reglas y buenas prácticas para la creación de tests de contratos utilizando Pact en el cliente React de nurBnb.

## Estructura y Organización
1. **Un archivo por servicio consumidor**: Cada servicio consumido debe tener su propio archivo de pruebas, ubicado en el directorio `src/tests/` (por ejemplo, `propiedad.spec.js` o `propiedad.test.js`).
2. **Instanciación única del PactV3**: Debe existir un solo objeto `PactV3` por archivo, instanciado una única vez en el bloque `describe` raíz, con el `consumer` y `provider` definidos de forma explícita.
3. **Anidación por funcionalidad**: Agrupar las pruebas utilizando bloques `describe` anidados por funcionalidad (ej. "Obtener lista de propiedades", "Registrar propiedad").
4. **Una interacción por prueba**: Cada bloque `it` debe representar una interacción HTTP concreta. **No se deben mezclar diferentes peticiones HTTP en el mismo `it`.**

## Buenas Prácticas Generales
- **Estados claros**: Definir correctamente los estados del proveedor (provider states) para cada interacción.
- **Nombres descriptivos**: Utilizar nombres claros para las interacciones (`uponReceiving`) que describan el escenario exacto que se está probando.
- **Datos dinámicos**: Utilizar los matchers de Pact (ej. `MatchersV3.like`, `MatchersV3.eachLike`) en lugar de valores estáticos y exactos en la respuesta, para evitar pruebas frágiles.
- **Validación rigurosa**: Siempre verificar (`executeTest`) la interacción del contrato con una petición real al mock server de Pact.

