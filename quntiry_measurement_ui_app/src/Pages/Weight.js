import React from 'react'
import { KgToGm, GmToKg } from '../Controller/Services';

export class Weight extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            weight:'',
             input:'',
             result:'',
        };
    }
    handleWeightChang = (event) => {
        const weight = event.target.value;
        this.setState({
            weight: weight
        });
        console.log("length", this.state.weight);
    }

    handleOnOption=(event)=>{
        this.setState({ input: event.target.value });
        console.log(this.state.input);
    }

    componentDidUpdate(){
        if(this.state.input=== 'Kilogram' && this.state.input!== 'Gram')
        KgToGm(this.state.weight).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting kg to gram----------", err);
        });

        if(this.state.input!== 'Kilogram' && this.state.input=== 'Gram')
        GmToKg(this.state.weight).then(response => {
            this.setState({result:response.data})
        }).catch((err) => {
            console.log("error while converting gram to kg----------", err);
        });
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleWeightChang} />
                    <select className="SelectItems" onClick={this.handleOnOption}>
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" value={this.state.result} />
                    <select className="SelectItems">
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
            </>
        )
    }
}
export default Weight;
