kind create cluster --config .\kindconfig.yaml

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml

kind load docker-image exampleapp:1.0

helm install --debug demo-app ./demo-app 
