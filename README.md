

# Projeto DIO Bank
Projeto realizado em Boot Camp no portal DIO - Digital Innovation One.
Primeiramente foi replicada a solução demonstrada pelo professor para posterior customização a ser realizada pelo próprio aluno.

## Alterações realizadas no projeto :smiling_imp:

- Número de conta (ID) como primeiro atributo na classe Conta
  - Adição de atributo no construtor da classe.
  - Adequação nos métodos Sacar(), Depositar() e Transferir().
- Personalizar ToString()
  - Alterado formato e incrementado casas decimais na visualização dos valores double.
  - Padronizada escrita decimal para "." utilizando CultureInfo.InvariantCulture.
- Organização de estrutura do projeto
  - Pastas e SubPastas (Entities e Enums)
  - Renomeado namespaces de acordo com nova estrutura
    - Classe Conta: DioBank.Entities
    - Enum TipoConta: DioBank.Entities.Enums



 
