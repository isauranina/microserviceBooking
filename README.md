# nurBnb - Cliente Consumidor (Contract Testing)

Este proyecto actúa como el **Cliente de la API Consumidora (nurBnb)** para el sistema de alquiler de propiedades, implementando un enfoque robusto de **Contract Testing** utilizando Pact (PactV3) y Jest.

## Características de Pruebas de Contratos (Pact)

* **Consumer-Driven Contracts**: Define interacciones HTTP esperadas con el proveedor de la API de Propiedades.
* **Orquestador Automático**: Contiene un agente IA orquestador (Pact Orchestrator) capaz de generar y verificar automáticamente nuevos contratos bajo demanda al detectar la palabra clave "pacto" o "contract-test".
* **Validación de Reglas (Pact Reviewer)**: Un flujo que garantiza el cumplimiento de reglas estrictas de pruebas (un solo `PactV3` por archivo, un bloque `it` por interacción HTTP, descripciones anidadas por funcionalidad).
* **Matchers Dinámicos**: Implementación de `MatchersV3.like` y `MatchersV3.eachLike` para crear pruebas resilientes y flexibles, comprobando tipos de respuesta en lugar de simples valores estáticos fijos.
* **Flujos Cubiertos**:
  * Obtención de lista de propiedades (`GET /api/Propiedad`).
  * Obtención de una propiedad por ID (`GET /api/Propiedad/{id}`).
  * Registro de nuevas propiedades (`POST /api/Propiedad`).

## Ejecución de las Pruebas

Para instalar las dependencias necesarias de las pruebas de contrato:
```bash
npm install
```

Para correr las pruebas generadas y validar el contrato con el Mock Server de Pact, ejecuta:
```bash
npm run test:pact
```

*(Los tests de contrato en JavaScript/Node.js residen actualmente en la carpeta `src/Eventos.Tests`)*

## Documentación de Reglas
Para más información sobre las directrices de los tests, consulta:
- [Reglas del Proyecto](project/pact-rules.md)
- [Pact Hook & Orchestrator](agents/pact-hook.md)
