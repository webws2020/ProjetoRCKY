import axios from 'axios';

const api = axios.create({
    baseURL: "http://localhost:51790/api/Cadastros"
})

export default api