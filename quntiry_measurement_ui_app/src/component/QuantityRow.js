import React from 'react'
import Length from '../Pages/Length';
import {Weight} from '../Pages/Weight';
import Temprature from '../Pages/Temprature';

export class QuantityRow extends React.Component {

    onChange = (e) => {
        this.props.history.push(`/${e.target.value}`);
      }

    render() {
        return (
            <div>
                
                <select className="SelectOption" onChange={this.onChange}>
                    <option value={Length}> Length</option>
                    <option value={Weight} > Weight</option>
                    <option value={Temprature}> Temprature</option>
                    
                </select>
                
            </div>
        )
    }
}
