# Pact Orchestrator Agent

Este archivo define el flujo de trabajo central del "Pact Orchestrator Agent", orquestado para ser reconocido universalmente por cualquier asistente de IA.

## Flujo de Trabajo del Pact Orchestrator Agent

1. **Ejecutar Pact-Generator:**
   - **Acción:** Lee y sigue las instrucciones del skill ubicado en `skills/pact-generator/SKILL.md`.
   - Lee las reglas fundamentales desde `project/pact-rules.md`.
   - Genera el test de contrato para el servicio o feature especificado.

2. **Ejecutar Pact-Reviewer (Verificación):**
   - **Acción:** Inmediatamente después de tener el código del test generado, pasa el contexto al skill ubicado en `skills/pact-reviewer/SKILL.md`.
   - El revisor debe contrastar el test generado con el feature solicitado y con las reglas de `project/pact-rules.md`.

3. **Entrega Final:**
   - Presenta al usuario el test generado junto con el diagnóstico del revisor (cumplimiento de reglas, cobertura funcional y sugerencias si las hay).
