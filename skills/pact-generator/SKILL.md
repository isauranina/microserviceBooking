---
name: Pact Generator
description: Genera pruebas de contratos (Pacts) para servicios o features específicos de la API consumidora.
---

# Pact Generator Skill

This skill helps generate Contract Tests (Pacts) for a specific service or feature in the React client, adhering to project rules.

## Instructions

1. **Read Project Rules:**
   - Before generating any Pact test, you MUST read the rules defined in `project/pact-rules.md` (do not hardcode the rules here, always read them directly from the file).

2. **Ask for the Target:**
   - Ask the user para qué servicio o feature específico se debe generar el pacto.

3. **Locate Related Files:**
   - Una vez identificado el servicio/feature, busca los archivos relacionados.
   - Utiliza la herramienta `codegraph` (si está inicializada) para encontrar dependencias y contexto. En su defecto, utiliza las herramientas de búsqueda (`grep_search`, `find_by_name`, o leer los archivos) para entender la estructura, endpoints y DTOs del servicio.

4. **Generate the Pact Test:**
   - Genera el test siguiendo estrictamente las reglas obtenidas de `project/pact-rules.md`.
   - Ubica el archivo generado en `src/tests/` con el nombre adecuado (ej. `[servicio].spec.js`).

5. **Present the Result:**
   - Muestra o guarda el archivo generado y notifica al usuario, confirmando que las interacciones se ajustan a las reglas requeridas.

