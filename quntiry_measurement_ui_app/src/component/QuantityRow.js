import React from 'react'
import Length from '../Pages/Length';
import Weight from '../Pages/Weight';
import Temprature from '../Pages/Temprature';


export class QuantityRow extends React.Component {
   
    render() {
        return (
            <div>
                <select className="SelectOption" >
                    <option value={Length}> Length</option>
                    <option value={Weight} > Weight</option>
                    <option value={Temprature}> Temprature</option>
                </select>
            </div>
        )
    }
}
