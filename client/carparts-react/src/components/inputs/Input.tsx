import React,{ useState } from "react";
import "./Input.scss";

interface User {
  firstName?: string;
  lastName?: string;
  username: string;
  email?: string;
  password: string;
  confirmPassword: string;
}

interface InputProps extends User {
  key: number;
  value:{
    [key:string]: string;
  }
  type:string;
  onChange: () => void;
  placeholder: string;
  label?: string;
  required?: boolean;
  errorMessage: string;
}

const Input: React.FC<InputProps> = ({
  placeholder,
  type,
  label,
  onChange,
  required,
  errorMessage,
}) => {
  const [focused, setFocused] = React.useState<boolean>(false);

  const handleFocus = () => {
    setFocused(true);
  };

  return (
    <div className="formInput">
      <label htmlFor="">{label}</label>
      <input
        required={required}
        placeholder={placeholder}
        onChange={onChange}
        onBlur={handleFocus}
        focused={focused.toString()}
        onFocus={() => value.name === "confirmPassword" && setFocused(true)}
      />
      <span>{errorMessage}</span>
    </div>
  );
};

export default Input;
