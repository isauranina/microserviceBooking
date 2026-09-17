const { PactV3, MatchersV3 } = require('@pact-foundation/pact');
const axios = require('axios');

const { eachLike, like, integer } = MatchersV3;

describe('Propiedad API Consumer Tests', () => {
  // 2. Un solo PactV3 por archivo, instanciando una vez en el describe raiz
  const provider = new PactV3({
    consumer: 'nurBnb-react-client',
    provider: 'propiedad-api'
  });

  // 3. Anidar describe por funcionalidad
  describe('Obtener lista de propiedades', () => {
    // 3. un it por interaccion http concreta
    it('Retorna una lista de propiedades al buscar por departamento', () => {
      // Configuracion de la interaccion esperada
      provider
        .given('existen propiedades tipo departamento')
        .uponReceiving('una peticion GET para buscar departamentos')
        .withRequest({
          method: 'GET',
          path: '/api/Propiedad',
          query: {
            searchTerm: 'departamento'
          }
        })
        .willRespondWith({
          status: 200,
          body: eachLike({
            descripcion: like('Departamento amoblado 2 dormitorios'),
            esVerificado: like(true),
            tipo: like('departamento')
          })
        });

      // Ejecucion del test contra el mock server de Pact
      return provider.executeTest(async (mockserver) => {
        const response = await axios.get(`${mockserver.url}/api/Propiedad`, {
          params: { searchTerm: 'departamento' }
        });
        
        expect(response.status).toEqual(200);
        expect(response.data[0].descripcion).toBeDefined();
        expect(response.data[0].esVerificado).toBeDefined();
        expect(response.data[0].tipo).toBeDefined();
      });
    });
  });

  describe('Obtener propiedad por ID', () => {
    it('Retorna los detalles de una propiedad especifica', () => {
      const propiedadId = '123e4567-e89b-12d3-a456-426614174000'; // Ejemplo UUID
      
      provider
        .given('existe una propiedad con el ID proporcionado')
        .uponReceiving('una peticion GET para obtener propiedad por ID')
        .withRequest({
          method: 'GET',
          path: `/api/Propiedad/${propiedadId}`
        })
        .willRespondWith({
          status: 200,
          body: {
            id: like(propiedadId),
            descripcion: like('Casa 3 plantas centro'),
            esVerificado: like(false),
            tipo: like('casa')
          }
        });

      return provider.executeTest(async (mockserver) => {
        const response = await axios.get(`${mockserver.url}/api/Propiedad/${propiedadId}`);
        
        expect(response.status).toEqual(200);
        expect(response.data.id).toBe(propiedadId);
        expect(response.data.descripcion).toBeDefined();
      });
    });
  });

  describe('Guardar propiedad', () => {
    it('Registra una nueva propiedad exitosamente', () => {
      const nuevaPropiedad = {
        descripcion: 'Departamento moderno cerca al centro',
        direccion: 'Av. Principal #123',
        esVerificado: true,
        tipo: 1
      };

      provider
        .given('el sistema esta listo para registrar propiedades')
        .uponReceiving('una peticion POST para registrar propiedad')
        .withRequest({
          method: 'POST',
          path: '/api/Propiedad',
          headers: {
            'Content-Type': 'application/json'
          },
          body: {
            descripcion: like(nuevaPropiedad.descripcion),
            direccion: like(nuevaPropiedad.direccion),
            esVerificado: like(nuevaPropiedad.esVerificado),
            tipo: like(nuevaPropiedad.tipo)
          }
        })
        .willRespondWith({
          status: 200,
          body: {
            id: like('123e4567-e89b-12d3-a456-426614174000'),
            descripcion: like(nuevaPropiedad.descripcion)
          }
        });

      return provider.executeTest(async (mockserver) => {
        const response = await axios.post(
          `${mockserver.url}/api/Propiedad`,
          nuevaPropiedad,
          {
            headers: {
              'Content-Type': 'application/json'
            }
          }
        );
        
        expect(response.status).toEqual(200);
        expect(response.data.id).toBeDefined();
      });
    });
  });
});

