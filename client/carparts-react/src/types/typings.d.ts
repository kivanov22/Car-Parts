interface Category {
    id: number,
    title: string,
    img: string,
}

interface User {
    id: number;
    name: string;
    type: string;
    placeholder: string;
    errorMessage: string;
    label: string;
}

// Define action types
export enum ActionTypes {
    ADD_PART = 'ADD_PART',
    DELETE_PART = 'DELETE_PART',
    EDIT_PART = 'EDIT_PART',
  }
  
  // Define action interfaces
  export interface AddPartAction {
    type: ActionTypes.ADD_PART;
    payload: Part;
  }
  
  export interface DeletePartAction {
    type: ActionTypes.DELETE_PART;
    payload: number; // id of the part to delete
  }
  
  export interface EditPartAction {
    type: ActionTypes.EDIT_PART;
    payload: Part;
  }
  
  export type Action = AddPartAction | DeletePartAction | EditPartAction;
