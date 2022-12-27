kind create cluster --config .\kindconfig.yaml

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/main/deploy/static/provider/kind/deploy.yaml

kind load docker-image exampleapp:1.0

kubectl apply -f .\deployment.yaml
kubectl apply -f .\service.yaml
# kubectl apply -f .\ingress.yaml