import axios from 'axios'

export const BASE_URL = 'https://localhost:7204/';

export const ENDPOINTS = {
    users : 'users'
}

export const createApiEndpoint = endPoint => {
    let url = `${BASE_URL}api/${endPoint}/`;

    return {
        fetch: () => axios.get(url),
        fetchById: id => axios.get(url + id),
        post: newRecord => axios.post(url, newRecord, {
            headers: {
                'Content-Type': 'application/json'
            }
        }),
        put: (id, updatedRecord) => axios.put(url + id, updatedRecord),
        delete: id => axios.delete(url + id),
    }
}

