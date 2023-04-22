import React, { useState } from "react";
import "./Register.scss";
import Input from "../../components/inputs/Input";

interface InputData {
  id: number;
  name: string;
  type: string | "email" | "password";
  placeholder: string;
  errorMessage: string;
  pattern?: string;
  label: string;
  required?: boolean;
}

interface UserData {
  firstName: string;
  lastName: string;
  username: string;
  email: string;
  password: string;
  confirmPassword: string;
}

// interface DataName {
//   [key: string]: string;
// }

const Register = () => {
  const [values, setValues] = React.useState<UserData>({
    firstName: "",
    lastName: "",
    username: "",
    email: "",
    password: "",
    confirmPassword: "",
  });

  const inputs: InputData[] = [
    {
      id: 1,
      name: "firstName",
      type: "text",
      placeholder: "FirstName",
      errorMessage:
        "Username should be 3-16 characters and shouldn't include any special character!",
      label: "FirstName",
    },
    {
      id: 2,
      name: "lastName",
      type: "text",
      placeholder: "LastName",
      errorMessage:
        "Username should be 3-16 characters and shouldn't include any special character!",
      label: "LastName",
      pattern: "^[A-Za-z0-9]{3,16}",
    },
    {
      id: 3,
      name: "username",
      type: "text",
      placeholder: "Username",
      errorMessage:
        "Username should be 3-16 characters and shouldn't include any special character!",
      label: "Username",
      pattern: "^[A-Za-z0-9]{3,16}",
      required: true,
    },
    {
      id: 4,
      name: "email",
      type: "email",
      placeholder: "Email",
      errorMessage: "It should be a valid email address!",
      label: "Email",

      required: true,
    },
    {
      id: 5,
      name: "password",
      type: "password",
      placeholder: "Password",
      errorMessage:
        "Password should be 8-20 characters and include at least 1 letter, 1 number and 1 special character!",
      label: "Password",
      required: true,
    },
    {
      id: 6,
      name: "confirmPassword",
      type: "password",
      placeholder: "Confirm Password",
      errorMessage: "Passwords don't match!",
      label: "Confirm Password",
      pattern: values.password,
      required: true,
    },
  ];

  const handleSubmit = (e: React.SyntheticEvent<HTMLFormElement>) => {
    e.preventDefault();
  };

  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setValues({ ...values, [e.target.name]: e.target.value });
  };

  return (
    <form className="register" onSubmit={handleSubmit}>
      <h1>Register</h1>
      {inputs.map((input) => (
        <Input
          key={input.id}
          label={input.label}
          placeholder={input.placeholder}
          type={input.type}
          value={values[input.name]}
          onChange={() => onChange}
          errorMessage={input.errorMessage}
        />
      ))}
      <button>Submit</button>
      <hr />
      <p>Already got an account, click here!</p>
    </form>
  );
};

export default Register;

// <label htmlFor="">Username</label>
// <input type="text" placeholder='enter username'/>
// <label htmlFor="">Password</label>
// <input type="text" placeholder='enter password'/>
// <label htmlFor="">Confirm Password</label>
// <input type="text" placeholder='enter password'/>
