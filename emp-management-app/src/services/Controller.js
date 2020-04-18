import axios from 'axios';

function userLogin(id, password) {

    return axios.get('https://localhost:44344/api/controller/LoginEmployee?Id=' + id + '&password=' + password)
};

function userRegistration(data) {
    return axios.post('https://localhost:44344/api/controller/AddEmployee', {
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        data
    })
};

function getEmployeeDetails() {
    return axios.get('https://localhost:44344/api/controller/GetAllEmployee')
};

function deteleEmployee(id) {
    return axios.delete('https://localhost:44344/api/controller/DeleteEmployee?id=' + id, {
        headers: {
            'Accept': 'application/json'
        }
    })
};

function updateEmployee(id, data) {
    return axios.put('https://localhost:44344/api/controller/UpdateEmployee?id=' + id, {
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: data,
    })
}

export default (userLogin, userRegistration, getEmployeeDetails, deteleEmployee, updateEmployee);
