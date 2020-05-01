import React, { Component } from 'react';
import { deleteEmployee, getAllData } from '../services/Controller'

export class EmployeeDetails extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Employee: [],
        };
    }

    componentDidMount() {
        getAllData()
            .then(results => {
                this.setState({ Employee: results.data });
                console.log(results.data);
            })
    }

    deleteEmployeedata = (id) => {
        if (window.confirm('Are you sure? '))
            deleteEmployee(id)
                .then(alert('success'))
                window.location.reload();
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
                                        <td> <button className="Update">update</button>
                                            <button onClick={() => this.deleteEmployeedata(emp.employeeId)} className="del">delete</button></td>
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
