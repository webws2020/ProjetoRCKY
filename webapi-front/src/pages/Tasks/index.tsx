import React, { useState, useEffect } from 'react';
import { Table, Button } from 'react-bootstrap';
import api from '../../services/api'

interface ITask {
  ID_funcionario: number;
  Nome: string;
  Endereco: string;
  Nascimento: string;
  Salario: string;
  Genero: string;
  
}

const Tasks: React.FC = () => {

  const [task, setTask] = useState<ITask[]>([])

  useEffect(() => {
    loadTasks()
  }, [])



  async function loadTasks() {

    const response = await api.get('/tasks')
    console.log(response)
    setTask(response.data)

  }

  return (
    <div className="container">
      <br />
      <h1>Cadastro de Funcionarios</h1>
      <br />
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Endereço</th>
            <th>Data de Nascimento</th>
            <th>Salário</th>
            <th>Genêro</th>
            <th>Ações</th>
          </tr>
        </thead>
        <tbody>

          {
            task.map(task => (
              <tr>
                <td>{task.ID_funcionario}</td>
                <td>{task.Nome}</td>
                <td>{task.Endereco}</td>
                <td>{task.Salario}</td>
                <td>{task.Genero}</td>
                <td>
                  <Button size="sm">Editar</Button> {''}
                  <Button size="sm">Criar</Button> {''}
                  <Button size="sm">Vizualizar</Button> {''}
                  <Button size="sm">Excluir</Button> {''}

                </td>
              </tr>
            ))
          }
        </tbody>
      </Table>
    </div>
  );

}

export default Tasks;