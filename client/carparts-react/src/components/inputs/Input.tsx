import React,{ useState } from "react";
import "./Input.scss";

interface InputProps {
  label:string,
  value:string,
  onChange:(value:string)=>void;
}


const Input: React.FC<InputProps> = ({
label,
value,
onChange
}) => {

  return (
    <div className="formInput">
      <label htmlFor="">{label}</label>
      <input
       value={value}
       onChange={(e)=>onChange(e.target.value)}
      />
    </div>
  );
};

export default Input;
