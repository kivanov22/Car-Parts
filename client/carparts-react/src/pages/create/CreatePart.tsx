import { Part, ChangeInput, ActionTypes } from "../../types/Part";
import {useMutation,useQuery,useQueryClient} from "@tanstack/react-query"
import { useReducer } from "react";

import "./CreatePart.scss";
import PartReducer from "../../reducers/PartReducer";
import { useNavigate } from "react-router-dom";
import axios from "axios";

const initalState: Part = {
  partName: "",
  partDescription: "",
  partNumber: 0,
  manufacturer: "",
  condition: "",
  material: "",
  size: 0,
  coverImage: "",
  images: [],
  category: "",
  make: "",
  model: "",
  price: 0,
};

const CreatePart: React.FC = () => {
  const [PartState, dispatch] = useReducer(PartReducer, initalState);
  const navigate = useNavigate();

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    const payload = { field: name, value };
    dispatch({
      type: ActionTypes.CHANGE_INPUT,
      payload: payload as ChangeInput["payload"],
    });
  };

  const addPartMutation = useMutation((newPart:Part)=>{
    return axios.post('https://localhost:7248/api/Part',newPart);
  });

  const handleSubmit =(e:React.FormEvent)=>{
    e.preventDefault();
    addPartMutation.mutate(PartState);
    navigate("/catalog")
  }

  return (
    <div className="create">
      <div className="container">
        <h1>Add New Part</h1>
        <div className="sections">
          <div className="left">
            <label htmlFor="">Part Name</label>
            <input type="text" name="partName" value={PartState.partDescription} onChange={handleChange}/>
            <hr />
            <label htmlFor="">Part Description</label>
            <textarea  id="" cols={10} rows={10} name="description" value={PartState.partDescription} onChange={handleChange}></textarea>
            <hr />
            <label htmlFor="">Part Number</label>
            <input type="text" name="partNumber" value={PartState.partNumber} onChange={handleChange} />
            <hr />
            <label htmlFor="">Manufacturer Number</label>
            <input type="text" name="manufacturer" value={PartState.manufacturer} onChange={handleChange}/>
            <hr />
            <label htmlFor="">Part Condition</label>
            <select  id="" name="condition" value={PartState.condition} onChange={handleChange}>
              <option value="">New</option>
              <option value="">Used</option>
            </select>
            <hr />
            <label htmlFor="">Part Material</label>
            <input type="text" name="material" value={PartState.material} onChange={handleChange}/>
            <hr />
            <label htmlFor="">Part Size</label>
            <input type="text" name="size" value={PartState.size} onChange={handleChange}/>
            <hr />
          </div>
          <div className="right">
            <div className="images">
              <div className="imagesInputs">
                <label htmlFor="">Cover Image</label>
                <input type="file" name="coverImage" value={PartState.coverImage} onChange={handleChange}/>
                <label htmlFor="">Upload Images</label>
                <input type="file" multiple name="images" value={PartState.images} onChange={handleChange}/>
              </div>
              <button>
                Upload
                {/* {uploading ? "uploading" : "upload"} */}
              </button>
            </div>
            <hr />
            <label htmlFor="">Category</label>
            <select  id="" name="category" value={PartState.category} onChange={handleChange}>
              <option value="">Cars</option>
              <option value="">Trucks</option>
              <option value="">Motorcycles</option>
            </select>
            <hr />
            <label htmlFor="">Part for Make </label>
            <select  id="" name="make" value={PartState.make} onChange={handleChange}>
              <option value="">Mercedes</option>
              <option value="">BMW</option>
              <option value="">Audi</option>
            </select>
            <hr />
            <label htmlFor="">Part for Model </label>
            <select  id="" name="model" value={PartState.model} onChange={handleChange}>
              <option value="">Q7</option>
              <option value="">X5</option>
              <option value="">C200</option>
            </select>
            <hr />
            <label htmlFor="">Price</label>
            <input type="text" name="price" value={PartState.price} onChange={handleChange}/>
            <hr />
          </div>
          <button onClick={handleSubmit}>Create</button>
        </div>
      </div>
    </div>
  );
};

export default CreatePart;
