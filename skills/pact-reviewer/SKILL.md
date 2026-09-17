---
name: Pact Reviewer
description: Verifica que los tests de contratos generados cumplan con la funcionalidad requerida y respeten las reglas del proyecto establecidas.
---

# Pact Reviewer Skill

This skill is designed to review and verify generated Pact tests, ensuring they align with the original feature intent and strictly follow the project's Pact rules.

## Instructions

1. **Read the Rules:**
   - Always start by reading the project rules defined in `project/pact-rules.md`. No exceptions.

2. **Understand the Target Feature:**
   - Pregunta al usuario o revisa el contexto para entender cuál era el "feature" o "servicio" específico que se pretendía cubrir con el test.
   - Analiza los requisitos funcionales de ese feature (rutas, métodos HTTP, propiedades esperadas en el request y response).

3. **Analyze the Generated Test File:**
   - Lee el archivo de prueba generado en `src/tests/` (por ejemplo, `src/tests/[servicio].spec.js`).
   - Revisa paso a paso el código generado, contrastándolo con:
     - **Regla 1:** ¿Es un archivo dedicado al consumidor correcto y en la ruta correcta?
     - **Regla 2:** ¿Existe solo UNA instanciación de `PactV3` en el `describe` raíz con `consumer` y `provider` explícitos?
     - **Regla 3:** ¿Están los `describe` anidados correctamente por funcionalidad?
     - **Regla 4:** ¿Hay exactamente un `it` por interacción HTTP concreta (sin peticiones mezcladas)?
     - **Buenas Prácticas:** ¿Usa matchers dinámicos? ¿Tiene nombres descriptivos? ¿Invoca `executeTest`?

4. **Verify Business Logic (Feature Compliance):**
   - Asegúrate de que los endpoints, los métodos, los query params o body del request, y los estados HTTP esperados correspondan exactamente a lo que requiere la funcionalidad solicitada.

5. **Provide a Diagnosis:**
   - Entrega un informe de diagnóstico claro al usuario detallando:
     - **Cumplimiento de Reglas:** Lista de qué reglas se cumplen y cuáles fallan.
     - **Cumplimiento Funcional:** Si el test cubre lo esperado por el feature.
     - **Acciones Correctivas:** Si hay fallos, provee sugerencias o el código corregido necesario para que el test sea válido.

