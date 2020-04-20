# Saipher projeto de teste - Andre Costa

O projeto está estruturado em duas pastas:
- fpfront - Código do Frontend
- fpback - Código do Backend

# Informações sobre o Backend

O código do backend utiliza dotnet para implementar uma API Rest contendo os seguintes métodos:

- Create - POST

Exemplo de chamada utilizando o curl:

curl --location --request POST 'https://localhost:5001/api/FlightPlan' \
--header 'Content-Type: application/json' \
--header 'Content-Type: application/json' \
--data-raw '{
  "flightNumber":"AZUL3123",
  "aircraftType":"B737",
  "aircraftPrefix":"PT-AZU",
  "fromAirport":"GRU",
  "toAirport":"BSB",
  "flightDateTime":"2020-05-14T03:45"
}'

- Update - PUT

Exemplo de chamada utilizando o curl:

curl --location --request PUT 'https://localhost:5001/api/FlightPlan/1' \
--header 'Content-Type: application/json' \
--header 'Content-Type: application/json' \
--data-raw '{
  "flightNumber":"AZUL3123",
  "aircraftType":"B737",
  "aircraftPrefix":"PT-AZU",
  "fromAirport":"GRU",
  "toAirport":"BSB",
  "flightDateTime":"2020-05-14T03:45"
}'

- Delete - DELETE

Exemplo de chamada utilizando o curl:

curl --location --request DELETE 'https://localhost:5001/api/FlightPlan/2'

- Lista - GET

Exemplo de chamada utilizando o curl:

curl --location --request GET 'https://localhost:5001/api/FlightPlan'

- Informação sobre a API - GET - https://localhost:5001/api/FlightPlan/info

Exemplo de chamada utilizando o curl:

curl --location --request GET 'https://localhost:5001/api/FlightPlan/info' \
--header 'Cookie: ARRAffinity=677ccf51ddbc35769908cc4f1d3bf6727dd496b2b396a5ba3254b729dd1c8513'

Como a idéia era só fazer um teste optei por utilizar a persistencia em memória.

Para iniciar o servidor utilize o seguinte comando:

dotnet run

Abra o seguinte endereço no browser para verificar que o servidor do backend está rodando:

https://localhost:5001/api/FlightPlan/info

Deve ser exibida uma lista com um número de versão e uma data/hora.


# Frontend

O código do frontend utiliza angular e comunica com o backend através da API Rest mencionada anteriormente.

Para iniciar o frontend utilize o seguinte comando em uma janela de terminal dentro do diretorio do frontend:

ng serve

Depois disso abra a seguinte pagina:

http://localhost:4200/

Será exibida a página inicial com a lista de planos de voo. Como não existe nada cadastrado é preciso cadastrar alguns planos de voo para poder testar.

