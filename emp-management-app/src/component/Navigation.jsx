import React, { Component } from 'react';
import { NavLink } from 'react-router-dom';
import {  Nav } from 'react-bootstrap';

export class Navigation extends Component {
    render() {
        return (
            <div className="navbar">
                    <Nav className="mr-auto">
                        <NavLink className="d-inline p-2 bg-dark text-white"
                         to="/">Home</NavLink>
                        <NavLink className="d-inline p-2 bg-dark text-white"
                         to="/Login">____Login</NavLink>
                        <NavLink className="d-inline p-2 bg-dark text-white" 
                         to="/Registration">_____Registration</NavLink>
                         <NavLink className="d-inline p-2 bg-dark text-white" 
                         to="/EmployeeDetails">_____EmpDetails</NavLink>
                    </Nav>
            </div>
        )
    };
}

