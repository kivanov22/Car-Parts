import axios, { AxiosError, AxiosRequestConfig, AxiosResponse } from 'axios';

interface ApiError {
  message: string;
}

export async function makeApiRequest<T>(
  method: AxiosRequestConfig['method'],
  url: string,
  data?: any,
  headers?: any,
): Promise<T> {
  try {
    const response: AxiosResponse<T> = await axios({
      method,
      url,
      data,
      headers,
    });
    return response.data;
  } catch (error: unknown) {
    if (axios.isAxiosError(error)) {
      const apiError = (error as AxiosError<ApiError>).response?.data;
      throw new Error(apiError?.message || 'An unknown error occurred.');
    } else {
      throw new Error('An unknown error occurred.');
    }
  }
}