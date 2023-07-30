import { Part, Action, ActionTypes } from "../types/Part";

// export const INITIAL_STATE={
//     partName:"",
//     partDescription:"",
//     partNumber:0,
//     manufacturer:"",
//     condition:"",
//     material:"",
//     size:0,
//     coverImage:"",
//     images:[],
//     category:"",
//     make:"",
//     model:"",
//     price:0,
// } ;

// export interface AppState {
//     carParts:Part[];
// }

// const initialState:AppState = {
//     carParts:[],
// }

// type Add = {type:"ADD_PART";payload:{}};

const PartReducer = (state: Part, action: Action): Part => {
    switch (action.type) {
        case ActionTypes.CHANGE_INPUT:
            return {
                ...state,
                [action.payload.field]:action.payload.value
            }
        // case ActionTypes.ADD_IMAGES:
        //     return {
        //         ...state,
        //         coverImage:action.payload.coverImage,

        //     }

        default:
            return state;
        
    }
}

export default PartReducer;
