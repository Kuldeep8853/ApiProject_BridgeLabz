import React from 'react'
import { InchToFeet, FeetToInch} from '../Controller/Services';

export class Length extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
             length:'',
             input:'',
             result:'',
        };
    }

    handleOnOption=(event)=>{
        this.setState({ input: event.target.value });
        console.log(this.state.input);
    }

    handleLengthChang = (event) => {
        this.setState({ length: event.target.value });
        console.log(this.state.length);
    }

    componentDidUpdate(){
        if(this.state.input=== 'Inch' && this.state.input!== 'Feet')
        InchToFeet(this.state.length).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting Inch to feet----------", err);
        });

        if(this.state.input!== 'Inch' && this.state.input=== 'Feet')
        FeetToInch(this.state.length).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting feet to----------", err);
        });

        }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleLengthChang} />
                    <select className="SelectItems" onClick={this.handleOnOption}>
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" value={this.state.result} />
                    <select className="SelectItems" >
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
            </>
        )
    };
}
export default Length;