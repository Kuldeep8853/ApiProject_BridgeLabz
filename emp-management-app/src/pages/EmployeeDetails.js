import React, { Component } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import deteleEmployee from '../services/Controller'
import UpdateEmployee from './UpdateEmplyee';

export class EmployeeDetails extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Employee: [],
        };
    }

    componentDidMount() {
        axios.get("https://localhost:44344/api/controller/GetAllEmployee")
            .then(results => {
                this.setState({ Employee: results.data });
                console.log(results.data);
            })
            .catch(function (error) {
                document.log(error);
            })
    }

    deleteEmployeedata = (id) => {
        if (window.confirm('Are you sure? '))
            deteleEmployee(id)
                .then(alert('success'))

    }


    render() {
        return (
            <>
                <div className="App">
                    <h2 id="record">All Employee Records</h2>
                </div>
                <div className="container_second">
                    <table className="table">
                        <tr>
                            <th>EmployeeId</th>
                            <th>Firstname</th>
                            <th>Lastname</th>
                            <th>PhoneNumber</th>
                            <th>Email</th>
                            <th>Password</th>
                            <th>Options</th>
                        </tr>
                        <tbody>
                            {
                                this.state.Employee.map(emp =>
                                    <tr key={emp.EmployeeId}>
                                        <td>{emp.employeeId}</td>
                                        <td>{emp.firstName}</td>
                                        <td>{emp.lastName}</td>
                                        <td>{emp.phoneNumber}</td>
                                        <td>{emp.email}</td>
                                        <td>{emp.password}</td>
                                        <td><Link to="./UpdateEmployee"><button onClick={()=> UpdateEmployee(emp.employeeId)} variant="success">edit</button></Link>
                                            <button onClick={() => this.deleteEmployeedata(emp.employeeId)} variant="danger">delete</button></td>
                                    </tr>
                                )
                            }
                        </tbody>
                    </table>
                </div>
            </>
        )
    }
}
export default EmployeeDetails;
